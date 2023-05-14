using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using System.Collections.Generic;
using System.Threading;
using static UnityEngine.Rendering.DebugUI.Table;
using System.Collections;




/// <summary>
/// Modified version of the ActionBasedController class present in the XRToolkit package. 
/// Allow to insert a delay during the update of rotation and position
/// </summary>
[AddComponentMenu("Custom XR Controller (Action-based) - Delayed")]
public class CustomXRActionBasedController : ActionBasedController
{
    /// <summary>
    /// Position dell'altro controller, necessario per la gestione del CHARACTER MIRROR
    /// </summary>
    [SerializeField]
    InputActionProperty _mirrorPositionAction;

    [SerializeField]
    InputBufferSO _inputBuffer;

    [SerializeField]
    InputBufferSO _otherHandInputBuffer;

    private bool _checkedInputReferenceActions = false;

    protected override void OnEnable()
    {
        base.OnEnable();
        _inputBuffer.Init();
    }

    protected override void UpdateTrackingInput(XRControllerState controllerState)
    {
        if (controllerState == null)
            return;

        var posAction = positionAction.action;
        var rotAction = rotationAction.action;
        var mirrorPosAction = _mirrorPositionAction.action;
        var hasPositionAction = posAction != null;
        var hasRotationAction = rotAction != null;
        var hasMirrorPosAction = mirrorPosAction != null;


        // Warn the user if using referenced actions and they are disabled
        if (!_checkedInputReferenceActions && (hasPositionAction || hasRotationAction))
        {
            if (IsDisabledReferenceAction(positionAction) || IsDisabledReferenceAction(rotationAction))
            {
                Debug.LogWarning("'Enable Input Tracking' is enabled, but Position and/or Rotation Action is disabled." +
                    " The pose of the controller will not be updated correctly until the Input Actions are enabled." +
                    " Input Actions in an Input Action Asset must be explicitly enabled to read the current value of the action." +
                    " The Input Action Manager behavior can be added to a GameObject in a Scene and used to enable all Input Actions in a referenced Input Action Asset.",
                    this);
            }

            _checkedInputReferenceActions = true;
        }

        // Update inputTrackingState
        controllerState.inputTrackingState = InputTrackingState.None;
        var inputTrackingStateAction = trackingStateAction.action;

        // Actions without bindings are considered empty and will fallback
        if (inputTrackingStateAction != null && inputTrackingStateAction.bindings.Count > 0)
        {
            controllerState.inputTrackingState = (InputTrackingState)inputTrackingStateAction.ReadValue<int>();
        }
        else
        {
            // Fallback to the device trackingState if m_TrackingStateAction is not valid
            var positionTrackedDevice = hasPositionAction ? posAction.activeControl?.device as TrackedDevice : null;
            var rotationTrackedDevice = hasRotationAction ? rotAction.activeControl?.device as TrackedDevice : null;
            var positionTrackingState = InputTrackingState.None;

            if (positionTrackedDevice != null)
                positionTrackingState = (InputTrackingState)positionTrackedDevice.trackingState.ReadValue();

            // If the tracking devices are different only the InputTrackingState.Position and InputTrackingState.Position flags will be considered
            if (positionTrackedDevice != rotationTrackedDevice)
            {
                var rotationTrackingState = InputTrackingState.None;
                if (rotationTrackedDevice != null)
                    rotationTrackingState = (InputTrackingState)rotationTrackedDevice.trackingState.ReadValue();

                positionTrackingState &= InputTrackingState.Position;
                rotationTrackingState &= InputTrackingState.Rotation;
                controllerState.inputTrackingState = positionTrackingState | rotationTrackingState;
            }
            else
            {
                controllerState.inputTrackingState = positionTrackingState;
            }
        }

        InputData actualInputData = new()
        {
            position = controllerState.position,
            rotation = controllerState.rotation
        };


        // Update position
        if (hasPositionAction && (controllerState.inputTrackingState & InputTrackingState.Position) != 0)
        {
            Vector3 pos = posAction.ReadValue<Vector3>();
            actualInputData.position = pos;
        }

        // Update rotation
        if (hasRotationAction && (controllerState.inputTrackingState & InputTrackingState.Rotation) != 0)
        {
            Quaternion rot = rotAction.ReadValue<Quaternion>();
            actualInputData.rotation = rot;
        }


        InputData calculatedPosRot = CalculatePosRot(actualInputData, hasMirrorPosAction);

        controllerState.position = calculatedPosRot.position;
        controllerState.rotation = calculatedPosRot.rotation;
    }

    /// <summary>
    /// Calcolate the position and rotation applying DELAY + CHARACTER MIRROR + LOCAL MIRROR
    /// </summary>
    /// <param name="input">Input values readed in thi frame</param>
    /// <param name="hasMirrorPosAction">if the mirror pos action is provided</param>
    /// <returns></returns>
    private InputData CalculatePosRot(InputData input, bool hasMirrorPosAction)
    {

        InputData retValue = new()
        {
            position = input.position,
            rotation= input.rotation
        };

        Vector3 mirroredPos = _mirrorPositionAction.action.ReadValue<Vector3>();

        int delay = GameManager.Instance.WorldData.Delay;
        bool localMirror = GameManager.Instance.WorldData.LocalMirror;
        bool characterMirror = GameManager.Instance.WorldData.CharacterMirror;
        bool rotationMirror = GameManager.Instance.WorldData.RotationMirror;

        int localMirrorMultiplier = localMirror ? -1 : 1; //Gestione LOCAL MIRROR


        if (delay > 0)
        {
            
            InputData readedData = _inputBuffer.ReadThenAddValue(input);

            if (readedData.isEmpty)
            {
                return retValue;
            }

            if (hasMirrorPosAction && characterMirror)
            {
                //CHARACTER-MIRROR + LOCAL-MIRROR
                //Specchio il valore solamente sull'asse X. Y e Z sono quelli originali

                InputData otherHandValue = _otherHandInputBuffer.LastReadedValue;

                retValue.position = new Vector3(readedData.position.x, otherHandValue.position.y, localMirrorMultiplier * otherHandValue.position.z); //Considero anche il LOCAL-MIRROR
                retValue.rotation = rotationMirror ? Quaternion.Inverse(otherHandValue.rotation) : otherHandValue.rotation;
            }
            else
            {
                //LOCAL-MIRROR
                //Specchio il valore solamente sull'asse X. Y e Z sono quelli originali
                retValue.position = new Vector3(readedData.position.x, readedData.position.y, localMirrorMultiplier * readedData.position.z);
                retValue.rotation = rotationMirror ? Quaternion.Inverse(readedData.rotation) : readedData.rotation;
            }
        }
        else
        {

            if (hasMirrorPosAction && characterMirror)
            {
                //CHARACTER-MIRROR + LOCAL-MIRROR
                //Specchio il valore solamente sull'asse Y. X e Z sono quelli originali
                retValue.position = new Vector3(input.position.x,mirroredPos.y, localMirrorMultiplier * input.position.z); //Considero anche il LOCAL-MIRROR
            }
            else
            {
                //LOCAL-MIRROR
                //Specchio il valore solamente sull'asse X. Y e Z sono quelli originali
                retValue.position = new Vector3(input.position.x, input.position.y, localMirrorMultiplier * input.position.z);
            }


            retValue.rotation = rotationMirror ? Quaternion.Inverse(input.rotation) : input.rotation;
        }

        return retValue;
    }


    static bool IsDisabledReferenceAction(InputActionProperty property) =>
            property.reference != null && property.reference.action != null && !property.reference.action.enabled;
}

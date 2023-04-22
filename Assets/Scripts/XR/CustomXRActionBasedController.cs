using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using System.Collections.Generic;
using System.Threading;
using static UnityEngine.Rendering.DebugUI.Table;
using System.Collections;

/// <summary>
/// struct that contains position and rotation data
/// </summary>
struct InputData
{
    public Vector3 position;
    public Quaternion rotation;
}


/// <summary>
/// Modified version of the ActionBasedController class present in the XRToolkit package. 
/// Allow to insert a delay during the update of rotation and position
/// </summary>
[AddComponentMenu("Custom XR Controller (Action-based) - Delayed")]
public class CustomXRActionBasedController : ActionBasedController
{
    private bool _checkedInputReferenceActions = false;
    private List<InputData> _inputBuffer = new();
    private int _readCounter;
    private int _writeCounter;

    protected override void UpdateTrackingInput(XRControllerState controllerState)
    {   
        //base.UpdateTrackingInput(controllerState);

        if (controllerState == null)
            return;

        var posAction = positionAction.action;
        var rotAction = rotationAction.action;
        var hasPositionAction = posAction != null;
        var hasRotationAction = rotAction != null;

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


        int delay = GameManager.Instance.WorldData.Delay;
        if (delay > 0)
        {
            if (_inputBuffer.Count > delay)
            {
                _inputBuffer.Clear();
            }

            if (_inputBuffer.Count < delay)
                _inputBuffer.Add(actualInputData);
            else
            {
                _readCounter++;
                if (_readCounter >= delay)
                    _readCounter = 0;
                InputData readedData = _inputBuffer[_readCounter];

                controllerState.position = readedData.position;
                controllerState.rotation = readedData.rotation;

                _writeCounter++;
                if (_writeCounter >= delay)
                    _writeCounter = 0;
                _inputBuffer[_writeCounter] = actualInputData;
            }

        }
        else
        {
            controllerState.position = actualInputData.position;
            controllerState.rotation = actualInputData.rotation;
        }
    }


    static bool IsDisabledReferenceAction(InputActionProperty property) =>
            property.reference != null && property.reference.action != null && !property.reference.action.enabled;
}

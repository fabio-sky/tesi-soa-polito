using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.XR.Interaction.Toolkit;

public class FolloHandMovementController : MonoBehaviour
{
    /// <summary>
    /// Transform of the gameObj that represent the user's real tracked hand
    /// </summary>
    [SerializeField]
    Transform _trackedHand;

    /// <summary>
    /// SerializedObj that contains the input buffer
    /// </summary>
    [SerializeField]
    InputBufferSO _inputHandBuffer;

    [SerializeField]
    InputBufferSO _otherInputHandBuffer;

    /// <summary>
    /// Contains input readed from the Buffer Manager. Could be the input delayed (if DELAY > 0) or the actual input
    /// </summary>
    private InputData _readedBufferData;

    void Start()
    {
        _inputHandBuffer.Init();
        StartCoroutine(DiscreteBufferManager());
    }

    void Update()
    {
        ManageBuffer();
        HandleMovement();
    }

    private void ManageBuffer()
    {
        InputData actualInputData = new()
        {
            position = _trackedHand.transform.position,
            rotation = _trackedHand.transform.rotation
        };

        InputData readedData = _inputHandBuffer.ReadThenAddValue(actualInputData);

        _readedBufferData = readedData.isEmpty ? actualInputData : readedData;
    }

    private void HandleMovement()
    {
        bool localMirror = GameManager.Instance.WorldData.LocalMirror;
        bool characterMirror = GameManager.Instance.WorldData.CharacterMirror;
        bool rotationMirror = GameManager.Instance.WorldData.RotationMirror;

        if (localMirror || characterMirror)
        {
            float localMirroMultiplier = localMirror ? -1.0f : 1.0f;

            if (characterMirror)
            {
                transform.localRotation = rotationMirror ? Quaternion.Inverse(_otherInputHandBuffer.LastRotation) : _otherInputHandBuffer.LastRotation;
                transform.Translate(_otherInputHandBuffer.LastMovement.normalized * (Time.deltaTime * (_otherInputHandBuffer.LastMovement.magnitude / 0.03f)) * localMirroMultiplier, Space.World);
            }
            else
            {
                transform.localRotation = rotationMirror ? Quaternion.Inverse(_inputHandBuffer.LastRotation) : _inputHandBuffer.LastRotation;
                transform.Translate(_inputHandBuffer.LastMovement.normalized * (Time.deltaTime * (_inputHandBuffer.LastMovement.magnitude / 0.03f)) * localMirroMultiplier, Space.World);
            }
            
        }
        else
        {
            InputData calculatedPosRot = CalculatePosRot(rotationMirror);
            transform.SetPositionAndRotation(calculatedPosRot.position, calculatedPosRot.rotation);
        }
    }

    /// <summary>
    /// Calcolate the position and rotation (with mirror if RotationMirror is enabled) based on the input value reade from the buffer (_readedBufferData)
    /// </summary>
    /// <returns>Position and Rotation to apply at the gameObj</returns>
    private InputData CalculatePosRot(bool rotationMirror)
    {

        return new()
        {
            position = new Vector3(_readedBufferData.position.x, _readedBufferData.position.y, _readedBufferData.position.z),
            rotation = rotationMirror ? Quaternion.Inverse(_readedBufferData.rotation) : _readedBufferData.rotation
        };
    }

    /// <summary>
    /// Coruoutine that read the input data and calculate the movement vector between the last two points. 
    /// </summary>
    /// <returns></returns>
    IEnumerator DiscreteBufferManager()
    {

        InputData newPosition;
        InputData oldPosition = new()
        {
            isEmpty = true,
        };

        while (true)
        {

            newPosition = new() { isEmpty = false, position = new Vector3(_readedBufferData.position.x, _readedBufferData.position.y, _readedBufferData.position.z), rotation = _readedBufferData.rotation };

            if (!oldPosition.isEmpty)
            {
                _inputHandBuffer.LastMovement = newPosition.position - oldPosition.position;
                _inputHandBuffer.LastRotation = newPosition.rotation;
            }

            oldPosition = new() { isEmpty = false, position = new Vector3(newPosition.position.x, newPosition.position.y, newPosition.position.z), rotation = newPosition.rotation };

            yield return new WaitForSeconds(0.03f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrackedController : MonoBehaviour
{
    public enum WhatHand
    {
        RIGHT,
        LEFT
    }
    [SerializeField] WhatHand handType;
    [SerializeField] string righthandTag = "RightHandFollow";
    [SerializeField] string lefthandTag = "LeftHandFollow";

    /// <summary>
    /// SerializedObj that contains the input buffer
    /// </summary>
    [SerializeField]
    InputBufferSO _inputHandBuffer;

    [SerializeField]
    InputBufferSO _otherInputHandBuffer;

    GameObject _handToForceFollow = null;
    HandChildrenStore _handToForceFollowTransforms = null;
    HandChildrenStore _handTransforms = null;

    private InputData _readedBufferData;

    // Start is called before the first frame update
    void Start()
    {
        if (handType == WhatHand.RIGHT) _handToForceFollow = GameObject.FindGameObjectWithTag(righthandTag);
        else _handToForceFollow = GameObject.FindGameObjectWithTag(lefthandTag);

        if (_handToForceFollow)
        {
            _handToForceFollowTransforms = _handToForceFollow.GetComponent<HandChildrenStore>();
        }

        _handTransforms = gameObject.GetComponent<HandChildrenStore>();

        _inputHandBuffer.Init();
        StartCoroutine(DiscreteBufferManager());
    }

    // Update is called once per frame
    void Update()
    {
        ManageBuffer();
        CloneTransform();
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

    private void ManageBuffer()
    {
        InputData actualInputData = new()
        {
            position = _handTransforms.wrist.transform.localPosition,
            rotation = _handTransforms.wrist.transform.localRotation
        };

        _readedBufferData = _inputHandBuffer.ReadThenAddValue(actualInputData);
    }



    private void HandleWristMovement()
    {
        bool localMirror = GameManager.Instance.WorldData.LocalMirror;
        bool characterMirror = GameManager.Instance.WorldData.CharacterMirror;
        bool rotationMirror = GameManager.Instance.WorldData.RotationMirror;

        float timeDelta = GameManager.Instance.SettingsData.PositionSampleSeconds;

        if (localMirror || characterMirror)
        {
            float localMirroMultiplier = localMirror ? -1.0f : 1.0f;

            if (characterMirror)
            {
                _handToForceFollowTransforms.wrist.transform.localRotation = rotationMirror ? Quaternion.Inverse(_otherInputHandBuffer.LastRotation) : _otherInputHandBuffer.LastRotation;
                _handToForceFollowTransforms.wrist.transform.Translate(_otherInputHandBuffer.LastMovement.normalized * (Time.deltaTime * (_otherInputHandBuffer.LastMovement.magnitude / timeDelta)) * localMirroMultiplier, Space.World);
            }
            else
            {
                _handToForceFollowTransforms.wrist.transform.localRotation = rotationMirror ? Quaternion.Inverse(_inputHandBuffer.LastRotation) : _inputHandBuffer.LastRotation;
                _handToForceFollowTransforms.wrist.transform.Translate(_inputHandBuffer.LastMovement.normalized * (Time.deltaTime * (_inputHandBuffer.LastMovement.magnitude / timeDelta)) * localMirroMultiplier, Space.World);
            }

        }
        else
        {
            InputData calculatedPosRot = CalculatePosRot(rotationMirror);
            _handToForceFollowTransforms.wrist.transform.SetPositionAndRotation(calculatedPosRot.position, calculatedPosRot.rotation);
        }
    }

    void CloneTransform()
    {
        if (_handToForceFollow == null || _handToForceFollowTransforms == null) return;

        //wrist
        HandleWristMovement();
        //_handToForceFollowTransforms.wrist.transform.SetLocalPositionAndRotation(_readedBufferData.position, _readedBufferData.rotation);

        //indexMetacarpal
        _handToForceFollowTransforms.indexMetacarpal.transform.localPosition = _handTransforms.indexMetacarpal.transform.localPosition;
        _handToForceFollowTransforms.indexMetacarpal.transform.localRotation = _handTransforms.indexMetacarpal.transform.localRotation;

        //indexProximal
        _handToForceFollowTransforms.indexProximal.transform.localPosition = _handTransforms.indexProximal.transform.localPosition;
        _handToForceFollowTransforms.indexProximal.transform.localRotation = _handTransforms.indexProximal.transform.localRotation;

        //indexIntermediate
        _handToForceFollowTransforms.indexIntermediate.transform.localPosition = _handTransforms.indexIntermediate.transform.localPosition;
        _handToForceFollowTransforms.indexIntermediate.transform.localRotation = _handTransforms.indexIntermediate.transform.localRotation;

        //indexDistal
        _handToForceFollowTransforms.indexDistal.transform.localPosition = _handTransforms.indexDistal.transform.localPosition;
        _handToForceFollowTransforms.indexDistal.transform.localRotation = _handTransforms.indexDistal.transform.localRotation;

        //indexTip
        _handToForceFollowTransforms.indexTip.transform.localPosition = _handTransforms.indexTip.transform.localPosition;
        _handToForceFollowTransforms.indexTip.transform.localRotation = _handTransforms.indexTip.transform.localRotation;

        //littleMetacarpal
        _handToForceFollowTransforms.littleMetacarpal.transform.localPosition = _handTransforms.littleMetacarpal.transform.localPosition;
        _handToForceFollowTransforms.littleMetacarpal.transform.localRotation = _handTransforms.littleMetacarpal.transform.localRotation;

        //littleProximal
        _handToForceFollowTransforms.littleProximal.transform.localPosition = _handTransforms.littleProximal.transform.localPosition;
        _handToForceFollowTransforms.littleProximal.transform.localRotation = _handTransforms.littleProximal.transform.localRotation;

        //littleIntermediate
        _handToForceFollowTransforms.littleIntermediate.transform.localPosition = _handTransforms.littleIntermediate.transform.localPosition;
        _handToForceFollowTransforms.littleIntermediate.transform.localRotation = _handTransforms.littleIntermediate.transform.localRotation;

        //littleDistal
        _handToForceFollowTransforms.littleDistal.transform.localPosition = _handTransforms.littleDistal.transform.localPosition;
        _handToForceFollowTransforms.littleDistal.transform.localRotation = _handTransforms.littleDistal.transform.localRotation;

        //littleTip
        _handToForceFollowTransforms.littleTip.transform.localPosition = _handTransforms.littleTip.transform.localPosition;
        _handToForceFollowTransforms.littleTip.transform.localRotation = _handTransforms.littleTip.transform.localRotation;

        //middleMetacarpal
        _handToForceFollowTransforms.middleMetacarpal.transform.localPosition = _handTransforms.middleMetacarpal.transform.localPosition;
        _handToForceFollowTransforms.middleMetacarpal.transform.localRotation = _handTransforms.middleMetacarpal.transform.localRotation;

        //middleProximal
        _handToForceFollowTransforms.middleProximal.transform.localPosition = _handTransforms.middleProximal.transform.localPosition;
        _handToForceFollowTransforms.middleProximal.transform.localRotation = _handTransforms.middleProximal.transform.localRotation;

        //middleIntermediate
        _handToForceFollowTransforms.middleIntermediate.transform.localPosition = _handTransforms.middleIntermediate.transform.localPosition;
        _handToForceFollowTransforms.middleIntermediate.transform.localRotation = _handTransforms.middleIntermediate.transform.localRotation;

        //middleDistal
        _handToForceFollowTransforms.middleDistal.transform.localPosition = _handTransforms.middleDistal.transform.localPosition;
        _handToForceFollowTransforms.middleDistal.transform.localRotation = _handTransforms.middleDistal.transform.localRotation;

        //middleTip
        _handToForceFollowTransforms.middleTip.transform.localPosition = _handTransforms.middleTip.transform.localPosition;
        _handToForceFollowTransforms.middleTip.transform.localRotation = _handTransforms.middleTip.transform.localRotation;

        //palm
        _handToForceFollowTransforms.palm.transform.localPosition = _handTransforms.palm.transform.localPosition;
        _handToForceFollowTransforms.palm.transform.localRotation = _handTransforms.palm.transform.localRotation;

        //ringMetacarpal
        _handToForceFollowTransforms.ringMetacarpal.transform.localPosition = _handTransforms.ringMetacarpal.transform.localPosition;
        _handToForceFollowTransforms.ringMetacarpal.transform.localRotation = _handTransforms.ringMetacarpal.transform.localRotation;

        //ringProximal
        _handToForceFollowTransforms.ringProximal.transform.localPosition = _handTransforms.ringProximal.transform.localPosition;
        _handToForceFollowTransforms.ringProximal.transform.localRotation = _handTransforms.ringProximal.transform.localRotation;

        //ringIntermediate
        _handToForceFollowTransforms.ringIntermediate.transform.localPosition = _handTransforms.ringIntermediate.transform.localPosition;
        _handToForceFollowTransforms.ringIntermediate.transform.localRotation = _handTransforms.ringIntermediate.transform.localRotation;

        //ringDistal
        _handToForceFollowTransforms.ringDistal.transform.localPosition = _handTransforms.ringDistal.transform.localPosition;
        _handToForceFollowTransforms.ringDistal.transform.localRotation = _handTransforms.ringDistal.transform.localRotation;

        //ringTip
        _handToForceFollowTransforms.ringTip.transform.localPosition = _handTransforms.ringTip.transform.localPosition;
        _handToForceFollowTransforms.ringTip.transform.localRotation = _handTransforms.ringTip.transform.localRotation;

        //thumbMetacarpal
        _handToForceFollowTransforms.thumbMetacarpal.transform.localPosition = _handTransforms.thumbMetacarpal.transform.localPosition;
        _handToForceFollowTransforms.thumbMetacarpal.transform.localRotation = _handTransforms.thumbMetacarpal.transform.localRotation;

        //thumbProximal
        _handToForceFollowTransforms.thumbProximal.transform.localPosition = _handTransforms.thumbProximal.transform.localPosition;
        _handToForceFollowTransforms.thumbProximal.transform.localRotation = _handTransforms.thumbProximal.transform.localRotation;

        //thumbDistal
        _handToForceFollowTransforms.thumbDistal.transform.localPosition = _handTransforms.thumbDistal.transform.localPosition;
        _handToForceFollowTransforms.thumbDistal.transform.localRotation = _handTransforms.thumbDistal.transform.localRotation;

        //thumbTip
        _handToForceFollowTransforms.thumbTip.transform.localPosition = _handTransforms.thumbTip.transform.localPosition;
        _handToForceFollowTransforms.thumbTip.transform.localRotation = _handTransforms.thumbTip.transform.localRotation;

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

            yield return new WaitForSeconds(GameManager.Instance.SettingsData.PositionSampleSeconds);
        }
    }
}

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

    // Update is called once per frame
    void Update()
    {
        ManageBuffer();
        CloneTransform();
        /*  if(_handToForceFollow == null)
          {
              if (handType == WhatHand.RIGHT) _handToForceFollow = GameObject.FindGameObjectWithTag(righthandTag);
              else _handToForceFollow = GameObject.FindGameObjectWithTag(lefthandTag);
          }
        */
    }

    void CloneTransform()
    {
        if (_handToForceFollow == null || _handToForceFollowTransforms == null) return;

        //wrist
        //_handToForceFollowTransforms.wrist.transform.localPosition = _handTransforms.wrist.transform.localPosition;
        //_handToForceFollowTransforms.wrist.transform.localRotation = _handTransforms.wrist.transform.localRotation;
        _handToForceFollowTransforms.wrist.transform.SetLocalPositionAndRotation(_readedBufferData.position, _readedBufferData.rotation);

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
}

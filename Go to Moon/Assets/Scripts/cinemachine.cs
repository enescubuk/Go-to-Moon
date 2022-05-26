using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[ExecuteInEditMode] [SaveDuringPlay] [ AddComponentMenu("")]
public class cinemachine : CinemachineExtension
{
    public float m_XPosition = 0;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.x = m_XPosition;
            state.RawPosition = pos;
        }
    }
}

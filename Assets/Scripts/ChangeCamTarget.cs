using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamTarget : MonoBehaviour
{
    CinemachineVirtualCamera cam;

    private void Awake()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
    }

    private void OnEnable()
    {
        FollowerController.NewCamTarget += SetNewCamTarget;
    }

    void SetNewCamTarget(Transform newTarget)
    {
        cam.m_Follow = newTarget;
        cam.m_LookAt = newTarget;
    }
}

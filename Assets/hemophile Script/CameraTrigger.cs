using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Collider player;
    private CameraManager camManager;
    public int cameraIdentity;

    private void Start()
    {
        camManager = FindObjectOfType<CameraManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other = player)
        {
            camManager.SwitchCamera(cameraIdentity);
        }
    }









}

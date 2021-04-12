using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hemophil_player : MonoBehaviour
{
    public Camera Cam;
    public float moveSpeed;
    private Vector3 moveAxes;

    private CharacterController controller;
    private float deadZone= 0.2f;

    private float horizAxis;
    private float vertAxis;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        // ---- gravity --------
        Vector3 gravity = Vector3.up * -9.81f;
        controller.Move(gravity);
        //----------------------

        //--- input managment ---
        if (Mathf.Abs( Input.GetAxis("Horizontal")) > deadZone)
        {
            horizAxis = Input.GetAxis("Horizontal");
        }
        else { horizAxis = 0; }


        if(Mathf.Abs(Input.GetAxis("Vertical")) > deadZone)
        {
            vertAxis = Input.GetAxis("Vertical");
        }
        else { vertAxis = 0; }
        //----------------------

        if (vertAxis != 0 || horizAxis != 0)
        {
            //------ movment -------     depending of camera.rotation
            Vector3 camF = Cam.transform.forward;
            Vector3 camR = Cam.transform.right;
            camF.y = 0;
            camR.y = 0;
            camF = camF.normalized;
            camR = camR.normalized;
            Vector3 dir = camF * vertAxis + camR * horizAxis;
            moveAxes = dir;

            controller.Move(dir * moveSpeed * Time.deltaTime);
            //----------------------

            transform.rotation = Quaternion.LookRotation(dir);
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + moveAxes);
    }


















}

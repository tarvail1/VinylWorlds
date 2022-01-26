using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseControl : MonoBehaviour
{
    [Header("Look Parameters")]
    Vector2 rotation = Vector2.zero;
    [SerializeField, Range(1,10)] private float lookSpeedX = 2f;
    [SerializeField, Range(1, 10)] private float lookSpeedy = 2f;
    [SerializeField, Range(1, 180)] private float upperLookLimit = 80f;
    [SerializeField, Range(1, 180)] private float lowerLookLimit = 80f;

    [SerializeField] private Camera playerCamera;
    private float rotationX = 0;
   
    
    void Awake()
    {
        //playerCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (CanMove)
        //{
            HandleMouseLook();
            
            ApplyFinalMovements();

        //}
    }

    private void HandleMouseLook()
    {
        rotation.y += Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0) == false)
        {
            rotation.x -= Input.GetAxis("Mouse Y");
            transform.eulerAngles = (Vector2) rotation * lookSpeedX;

        }
         //rotationX = Mathf.Clamp(rotationX, -upperLookLimit, lowerLookLimit);
        //playerCamera.transform.localRotation = Quaternion.Euler(rotationX,0,0);
       // playerCamera.transform.localRotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeedX,0);
        
    }

    private void ApplyFinalMovements()
    {
        
        
    }
    
}

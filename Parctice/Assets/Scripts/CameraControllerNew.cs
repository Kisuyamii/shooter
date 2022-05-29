using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerNew : MonoBehaviour
{
    public float sensX;
    public float sensY;

    Camera cam;

    float yRotation;
    float xRotation;

    private void Start() {
        cam = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update() {
        MyInput();

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    void MyInput()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        float mouseY = Input.GetAxisRaw("Mouse Y");

        yRotation += mouseX * sensX * 0.01f;
        xRotation -= mouseY * sensY * 0.01f;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}

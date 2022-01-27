using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightCameraRig : MonoBehaviour
{

    public float speed = 10;

    private float pitch = 0;
    private float yaw = 0;

    public float mouseSensitivityX = 1;
    public float mouseSensitivityY = 1;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {

        // ==== update position: ====

        float v = Input.GetAxis("Vertical"); // forward / back
        float h = Input.GetAxis("Horizontal"); // left / right (strafe)

        Vector3 dir = transform.forward * v + transform.right * h;
        if (dir.magnitude > 1) dir.Normalize();

        transform.position += dir * Time.deltaTime * speed;

        // ==== update rotation: ====

        float mx = Input.GetAxis("Mouse X"); // yaw (Y)
        float my = Input.GetAxis("Mouse Y"); // pitch (X)

        yaw += mx * mouseSensitivityX;
        pitch += my * mouseSensitivityY;

        pitch = Mathf.Clamp(pitch, -89, 89);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);

    }
}

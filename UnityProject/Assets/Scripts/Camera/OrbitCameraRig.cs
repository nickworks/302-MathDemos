using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCameraRig : MonoBehaviour
{

    public Transform thingToLookAt;

    private float pitch = 0;
    private float yaw = 0;
    private float dis = 10;

    public float mouseSensitivityX = 1;
    public float mouseSensitivityY = 1;
    public float scrollSensitivity = 1;

    private Camera cam;

    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }
    
    void LateUpdate()
    {

        // === rotation: ===

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        yaw += mx * mouseSensitivityX;
        pitch += my * mouseSensitivityY;
        pitch = Mathf.Clamp(pitch, -89, 89);

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);

        // === dolly: === (zoom)

        Vector2 scrollAmt = Input.mouseScrollDelta;
        dis += scrollAmt.y * scrollSensitivity;
        dis = Mathf.Clamp(dis, 5, 50);

        float z = AnimMath.Ease(cam.transform.localPosition.z, -dis, .01f);

        cam.transform.localPosition = new Vector3(0, 0, z);

        // === position: ===
        if (thingToLookAt == null) return;

        // snap to target:
        // transform.position = thingToLookAt.position;

        // ease towards target:
        transform.position = AnimMath.Ease(transform.position, thingToLookAt.position, .001f);

    }
}

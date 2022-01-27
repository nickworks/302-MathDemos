using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCameraRig : MonoBehaviour
{
    public Transform target;
    public float desiredDistance = 10;

    void LateUpdate()
    {
        Vector3 vToTarget = target.position - transform.position;

        // === position the camera ===
        Vector3 targetPosition = -vToTarget;
        targetPosition.Normalize();
        targetPosition *= desiredDistance;
        targetPosition += target.position;

        transform.position = AnimMath.Ease(transform.position, targetPosition, .01f);

        // === turning to look at target ==
        transform.rotation = Quaternion.LookRotation(vToTarget, new Vector3(0, 1, 0));
    }
}

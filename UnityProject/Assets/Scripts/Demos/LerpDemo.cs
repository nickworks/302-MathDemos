using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;

    //[Range(0, 1)]
    public float percent = 0;

    void DoInterpolation() {

        if (pointA == null) return;
        if (pointB == null) return;

        // lerp of position:
        Vector3 pos = AnimMath.Lerp(pointA.position, pointB.position, percent, false);

        // lerp of rotation:
        Quaternion rot = AnimMath.Lerp(pointA.rotation, pointB.rotation, percent);

        transform.position = pos;
        transform.rotation = rot;
    }
    private void OnValidate() {
        DoInterpolation();
        
    }
}

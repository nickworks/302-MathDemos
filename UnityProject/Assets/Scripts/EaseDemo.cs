using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EaseDemo : MonoBehaviour
{

    public Transform target;
    public float percentLeftAfter1Second = .0001f;
    
    void Start()
    {
        
    }


    void Update()
    {
        // naive:
        //transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime);

        transform.position = AnimMath.Ease(transform.position, target.position, percentLeftAfter1Second, Time.deltaTime);

    }
}

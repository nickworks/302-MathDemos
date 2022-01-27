using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDemo : MonoBehaviour
{

    [Range(0, 3)]
    public float timeScale = 1;

    void Update()
    {
        Time.timeScale = timeScale;
        // Time.deltaTime = Time.unscaledDeltaTime * Time.timeScale
    }
}

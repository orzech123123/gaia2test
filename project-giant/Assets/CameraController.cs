using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var x = GetComponent<Camera>();
        x.depth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateColectible : MonoBehaviour
{
    private int rotY = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotY++;
        transform.rotation = Quaternion.Euler(new Vector3(0f,rotY,0f));
    }
}

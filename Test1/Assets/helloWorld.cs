using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helloWorld : MonoBehaviour
{
    Camera m_MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.gyro.enabled)
        {
           Camera.main.transform.position += this.transform.forward * Input.gyro.userAcceleration.x;
        }
        
    }
}

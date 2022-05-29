using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincamera : MonoBehaviour
{

    public Camera cam;

    void Start()
    {
      transform.position = new Vector3(0, 100, 0);
      transform.Rotate(90, 0, 0);
      
      cam = GetComponent<Camera>();
      cam.clearFlags = CameraClearFlags.SolidColor;
      cam.backgroundColor = Color.black;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0, 0);
        }
    }
}

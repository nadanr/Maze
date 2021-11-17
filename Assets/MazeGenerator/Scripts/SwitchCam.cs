using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    protected bool cam2Disable = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            cam2Disable = !cam2Disable;
        }

        if (cam2Disable)
        {
            cam2.enabled = true;
            cam1.enabled = false;
        }
        else if (!cam2Disable)
        {
            cam2.enabled = false;
            cam1.enabled = true;
        }
    }
}

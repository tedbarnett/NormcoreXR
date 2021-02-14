using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableXRDeviceSimulator : MonoBehaviour
{
    public GameObject XRDeviceSimulator;

    void Awake()
    {

#if UNITY_EDITOR
        Debug.Log("Running Unity Editor, so will enable XR Device Simulator");
        XRDeviceSimulator.SetActive(true);
#endif

    }


    void Update()
    {
        
    }
}

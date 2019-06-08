using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using Random = UnityEngine.Random;

public class moveCharecter : MonoBehaviour
{
    private bool m_ButtonClick;
    private float m_moveSpeed;
    private Vector3 m_MoveStep;

    private Camera m_Camera;
    // Start is called before the first frame update
    void Start()
    {
        m_ButtonClick = false;
        m_MoveStep = new Vector3();
        m_moveSpeed = 10f;

        m_Camera = Camera.main;
    }
    private void Awake()
    {
        StartCoroutine(SwitchToVR());
    }

    IEnumerator SwitchToVR()
    {
        // Device names are lowercase, as returned by `XRSettings.supportedDevices`.
        string desiredDevice = "cardboard"; // Or "daydream".

        // Some VR Devices do not support reloading when already active, see
        // https://docs.unity3d.com/ScriptReference/XR.XRSettings.LoadDeviceByName.html
        if (String.Compare(UnityEngine.XR.XRSettings.loadedDeviceName, desiredDevice, true) != 0)
        {
            UnityEngine.XR.XRSettings.LoadDeviceByName(desiredDevice);

            // Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
            yield return null;
        }

        // Now it's ok to enable VR mode.
        UnityEngine.XR.XRSettings.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_ButtonClick = true;
        }
        else
        {
            //Vector3 desiredMove = transform.forward * m_Input.y + transform.right * m_Input.x;
            //transform.forward
        }
        if (m_ButtonClick)
        {
            MoveCharecter();
        }
    }
    private void MoveCharecter()
    {
        Debug.Log("Button is clicked1");
        if (transform.position.z > -50)
        {
            Debug.Log("Button is clicked2");
            m_MoveStep = Camera.main.transform.forward;
            Debug.Log(m_MoveStep);
            //m_MoveStep.y = 0;
            transform.position = transform.position + m_MoveStep * m_moveSpeed * Time.deltaTime;
            Debug.Log(transform.position);
            Debug.Log(transform.ToString());
            Debug.Log(Camera.main.transform.position);
            Debug.Log(m_Camera.transform.localPosition);
            //m_Camera.transform.localPosition = transform.position + 5f * m_MoveStep;
            //Debug.Log(m_Camera.transform.localPosition);

        }
        m_ButtonClick = false;
    }
}
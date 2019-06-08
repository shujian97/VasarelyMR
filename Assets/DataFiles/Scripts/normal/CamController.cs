using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public float speed;
    private GameObject up;
    private GameObject down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = transform.position + Camera.main.transform.forward * .5f * Time.deltaTime;
        }
    }
}

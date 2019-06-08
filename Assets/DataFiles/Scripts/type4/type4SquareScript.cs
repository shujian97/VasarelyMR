using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type4SquareScript : MonoBehaviour
{
    private bool isTouched;
    private float enter_time;
    private float exit_Time;
    //private GameObject ob;
    // Start is called before the first frame update
    void Start()
    {
        isTouched = false;
    }
    private void OnMouseDown()
    {
        isTouched = true;
        enter_time = Time.deltaTime;
        Debug.Log("Mouse down");
    }
    private void OnMouseUp()
    {
        isTouched = false;
        exit_Time = Time.deltaTime;
        Debug.Log("Mouse up");
    }
    // Update is called once per frame
    void Update()
    {
        if (isTouched == false)
        {
            return;
        }else if(isTouched == true)
        {
            transform.localScale += new Vector3(1.0f, 1f, 1f) * Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topButtonScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
   
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
        float moveCam = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotateCam = 0;
        //Camera cam = gameObject.GetComponent<Camera>();

        if (isTouched == false)
        {
            return;
        }
        else if (isTouched == true)
        {
            transform.Translate(0, 0, moveCam);
            rotateCam -= 1;
        }
        transform.Rotate(0, rotateCam, 0);
    }
}

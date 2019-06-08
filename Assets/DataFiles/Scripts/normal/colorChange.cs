using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject square = GameObject.Find("square");
        square.GetComponent<SpriteRenderer>().material.color = 
            //Color.blue;
            //new Color(0, 50, 255, 255);
        new Color(1f, 255f, 0, 1f);
        //square.GetComponent<SpriteRenderer>().material.SetColor("color",Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

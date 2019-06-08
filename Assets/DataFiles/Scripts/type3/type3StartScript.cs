using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type3StartScript : MonoBehaviour
{
    private GameObject currentPoint;
    private SpriteRenderer currentSprite;
    private Material currentMaterial;
    private Shader currentShader;

    private float holdTime;
    private float speed;

    private int mode;
    // Start is called before the first frame update
    void Start()
    {
        mode = 2;
        speed = (float)0.2;
        holdTime = 0;
        currentPoint = GameObject.Find("artwork");
        currentSprite = currentPoint.GetComponent<SpriteRenderer>();
        currentMaterial = currentSprite.material;
        currentShader = currentMaterial.shader;
        //currentSprite = currentPoint.GetComponent<SpriteRenderer>();
        //currentMaterial = currentPoint.GetComponent<Material>();
        //currentShader = currentPoint.GetComponent<Shader>();
        Debug.Log(currentPoint + "  " + currentSprite + "   " + currentMaterial + "     " + currentShader);
        Debug.Log(currentPoint);
    }

    void Update()
    {
        if (mode == 1)
        {

        }
        else if (mode == 2)
        {
            if (Input.GetMouseButton(0))
            {
                float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
                Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
                //transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.z);
                //renderFunction(pos_move.x,pos_move.y);
                holdTime += Time.deltaTime;

                pos_move.x = (pos_move.x + (float)2.8) / (float)5.6;
                pos_move.y = (pos_move.y + (float)2.8) / (float)5.6;
                renderFunction(pos_move.x, pos_move.y, holdTime);
                Debug.Log(pos_move.x + "  " + pos_move.y + "  " + holdTime);
            }
            if (Input.GetMouseButtonUp(0))
            {
                holdTime = 0f;
            }
        }
        else if (mode == 3)
        {
            
        }
        else if (mode == 4)
        {
            
        }
        //currentSprite.sharedMaterial.SetFloat("_Radius",(float)0.5);
    }
    private void OnMouseDown()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        //transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.z);
        //renderFunction(pos_move.x,pos_move.y);
        //pos_move.x = (pos_move.x + (float)2.8)/(float)5.6;
        //pos_move.y = (pos_move.y + (float)2.8) / (float)5.6;
        holdTime += Time.deltaTime;
        renderFunction(pos_move.x, pos_move.y, holdTime);
    }
    void renderFunction(float centerPossitionX, float centerPossitionY, float time)
    {
        currentSprite.sharedMaterial.SetFloat("_Radius", time * speed);
        currentSprite.sharedMaterial.SetFloat("_CenterX", centerPossitionX);
        currentSprite.sharedMaterial.SetFloat("_CenterY", centerPossitionY);
    }
}


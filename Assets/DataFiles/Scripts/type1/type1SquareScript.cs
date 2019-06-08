using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type1SquareScript : MonoBehaviour
{
    private GameObject square1;
    private GameObject square2;
    private GameObject square3;
    private GameObject square4;
    private GameObject square5;
    private GameObject square6;
    private GameObject square7;
    private GameObject square8;
    private GameObject square9;
    private GameObject square10;
    private GameObject square11;
    private GameObject square12;
    private GameObject square13;
    private GameObject square14;
    private GameObject square15;
    private GameObject square16;
    private GameObject square17;
    private GameObject square18;
    private GameObject square19;
    private GameObject square20;
    private GameObject square21;
    private GameObject square22;
    private GameObject square23;
    private GameObject square24;
    private GameObject square25;
    private GameObject square26;
    private GameObject square27;
    private GameObject square28;
    private GameObject square29;
    private GameObject square30;
    private GameObject fullSquare;
    private GameObject[] squares;
    private int n = 30;
    // Start is called before the first frame update
    void Start()
    {
        square1 = GameObject.Find("centreSquare");
        square2 = GameObject.Find("square2");
        square3 = GameObject.Find("square3");
        square4 = GameObject.Find("square4");
        square5 = GameObject.Find("square5");
        square6 = GameObject.Find("square6");
        square7 = GameObject.Find("square7");
        square8 = GameObject.Find("square8");
        square9 = GameObject.Find("square9");
        square10 = GameObject.Find("square10");
        square11 = GameObject.Find("square11");
        square12 = GameObject.Find("square12");
        square13 = GameObject.Find("square13");
        square14 = GameObject.Find("square14");
        square15 = GameObject.Find("square15");
        square16 = GameObject.Find("square16");
        square17 = GameObject.Find("square17");
        square18 = GameObject.Find("square18");
        square19 = GameObject.Find("square19");
        square20 = GameObject.Find("square20");
        square21 = GameObject.Find("square21");
        square22 = GameObject.Find("square22");
        square23 = GameObject.Find("square23");
        square24 = GameObject.Find("square24");
        square25 = GameObject.Find("square25");
        square26 = GameObject.Find("square26");
        square27 = GameObject.Find("square27");
        square28 = GameObject.Find("square28");
        square29 = GameObject.Find("square29");
        square30 = GameObject.Find("fullSquare");
        fullSquare = GameObject.Find("fullSquare");
        squares = new GameObject[n];
        squares[0] = square1;
        squares[1] = square2;
        squares[2] = square3;
        squares[3] = square4;
        squares[4] = square5;
        squares[5] = square6;
        squares[6] = square7;
        squares[7] = square8;
        squares[8] = square9;
        squares[9] = square10;
        squares[10] = square11;
        squares[11] = square12;
        squares[12] = square13;
        squares[13] = square14;
        squares[14] = square15;
        squares[15] = square16;
        squares[16] = square17;
        squares[17] = square18;
        squares[18] = square19;
        squares[19] = square20;
        squares[20] = square21;
        squares[21] = square22;
        squares[22] = square23;
        squares[23] = square24;
        squares[24] = square25;
        squares[25] = square26;
        squares[26] = square27;
        squares[27] = square28;
        squares[28] = square29;
        squares[29] = square30;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        //Debug.Log("Square size: " + square1.GetComponent<SpriteRenderer>().size.x + " Possition x: " + pos_move.x + " Possition y: " + pos_move.y);
        Debug.Log("Center1 x: " + square1.GetComponent<SpriteRenderer>().bounds.size.x);
        Debug.Log("Center2 x: " + square2.GetComponent<SpriteRenderer>().bounds.size.x);
        Debug.Log("Center x: " + square1.transform.position.x);
        Debug.Log("square2 x : " + square2.transform.position.x + "square2 half: " + square2.GetComponent<SpriteRenderer>().size.x * 0.5 + " Possition x: " + pos_move.x + " Possition y: " + pos_move.y);
        float currentX = pos_move.x;
        float currentY = pos_move.y;
        if (pos_move.x > square2.GetComponent<SpriteRenderer>().bounds.size.x * 0.5 + square2.transform.position.x - square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5
        ) {
            currentX = (float)(square2.GetComponent<SpriteRenderer>().bounds.size.x * 0.5 + square2.transform.position.x - square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5);
        }
        if (pos_move.x < -square2.GetComponent<SpriteRenderer>().bounds.size.x * 0.5 + square2.transform.position.x + square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5)
        {
            currentX = (float)(-square2.GetComponent<SpriteRenderer>().bounds.size.x * 0.5 + square2.transform.position.x + square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5);
        }
        if (pos_move.y > square2.GetComponent<SpriteRenderer>().bounds.size.y * 0.5 + square2.transform.position.y - square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5)
        {
            currentY = (float)(square2.GetComponent<SpriteRenderer>().bounds.size.y * 0.5 + square2.transform.position.y - square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5);
        }
        if (pos_move.y < -square2.GetComponent<SpriteRenderer>().bounds.size.y * 0.5 + square2.transform.position.y + square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5) 
        {
            currentY = (float)(-square2.GetComponent<SpriteRenderer>().bounds.size.y * 0.5 + square2.transform.position.y + square1.GetComponent<SpriteRenderer>().bounds.size.x * 0.5);
        }
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.z);
        resetAll(transform.position.x, transform.position.y);
        transform.position = new Vector3(currentX, currentY, transform.position.z);
              
    }
    void resetAll(float centerPossitionX, float centerPossitionY)
    {
        float diffLeftX = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.x - square1.GetComponent<SpriteRenderer>().bounds.size.x + 2*centerPossitionX) / (2 * (n * n - n));
        float diffRightX = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.x - square1.GetComponent<SpriteRenderer>().bounds.size.x - 2*centerPossitionX) / (2 * (n * n - n));
        float diffTopY = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.y - square1.GetComponent<SpriteRenderer>().bounds.size.y - 2*centerPossitionY) / (2*(2*n - 2));
        float diffBottomY = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.y - square1.GetComponent<SpriteRenderer>().bounds.size.y + 2*centerPossitionY) / (2*(2*n - 2));
        //float diffTopY = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.y - square1.GetComponent<SpriteRenderer>().bounds.size.y - 2 * centerPossitionY) / (2 * n - 2);
        //float diffBottomY = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.y - square1.GetComponent<SpriteRenderer>().bounds.size.y + 2 * centerPossitionY) / (2 * n - 2);
        Debug.Log("diffTopY: "+diffTopY + "diffBottomY: " + diffBottomY);
        //for (int i = 1; i < n; i++)
        //{
        //   // Debug.Log("i = " + i );
        //    //moving Y to top and bottom
        //    squares[i].transform.localScale = squares[i - 1].transform.localScale + new Vector3(0, diffTopY, 0);
        //    squares[i].transform.position = squares[i - 1].transform.position + new Vector3(0, (float)0.5*diffTopY, 0);
        //    squares[i].transform.localScale = squares[i].transform.localScale + new Vector3(0, diffBottomY, 0);
        //    squares[i].transform.position = squares[i].transform.position - new Vector3(0, (float)0.5*diffBottomY, 0);
        //    //moving x to left and right
        //    squares[i].transform.localScale = squares[i].transform.localScale + new Vector3((n - i) * diffLeftX, 0, 0);
        //    squares[i].transform.position = squares[i].transform.position - new Vector3((float)0.5 * (n - i) * diffLeftX, 0, 0);
        //    squares[i].transform.localScale = squares[i].transform.localScale + new Vector3(i * diffRightX, 0, 0);
        //    squares[i].transform.position = squares[i].transform.position + new Vector3((float)(0.5 * i * diffRightX), 0, 0);
        //}

        for (int i = n-2; i > 0; i--)
        {
            // Debug.Log("i = " + i );
            //moving Y to top and bottom
            squares[i].transform.localScale = squares[i + 1].transform.localScale - new Vector3(0, diffTopY, 0);
            squares[i].transform.position = squares[i + 1].transform.position - new Vector3(0, (float)0.5 * diffTopY, 0);
            squares[i].transform.localScale = squares[i].transform.localScale - new Vector3(0, diffBottomY, 0);
            squares[i].transform.position = squares[i].transform.position + new Vector3(0, (float)0.5 * diffBottomY, 0);
            //moving x to left and right
            squares[i].transform.localScale = squares[i].transform.localScale - new Vector3(i * diffLeftX, 0, 0);
            squares[i].transform.position = squares[i].transform.position + new Vector3((float)0.5 * i * diffLeftX, 0, 0);
            squares[i].transform.localScale = squares[i].transform.localScale - new Vector3((n - i) * diffRightX, 0, 0);
            squares[i].transform.position = squares[i].transform.position - new Vector3((float)(0.5 * (n - i) * diffRightX), 0, 0);
        }
    }
}

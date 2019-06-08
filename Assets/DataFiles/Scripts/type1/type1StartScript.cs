using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class type1StartScript : MonoBehaviour
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
    //private GameObject artwork;
    //private Transform artwork_Transform;
    private int n = 30;

    // Start is called before the first frame update
    void Start()
    {
        //artwork = GameObject.Find("artwork");
        //artwork_Transform = artwork.transform;
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
        //float diffN = (float)0.98 * square1.GetComponent<SpriteRenderer>().bounds.size.x;
        //float diff0 = (float)0.02 * square1.GetComponent<SpriteRenderer>().bounds.size.x;
        float diffX = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.x - square1.GetComponent<SpriteRenderer>().bounds.size.x) / (2 * (n * n - n));
        float diffY = (fullSquare.GetComponent<SpriteRenderer>().bounds.size.y - square1.GetComponent<SpriteRenderer>().bounds.size.y) / (2 * n - 2);
        Debug.Log(fullSquare.GetComponent<SpriteRenderer>().bounds.size.y);
        Debug.Log(square1.GetComponent<SpriteRenderer>().bounds.size.y);
        Debug.Log("DiffX: " + diffX);
        Debug.Log("DiffY: " + diffY);
        Debug.Log("sum : " + (n * n - n) * diffX);
        Debug.Log("widest : " + (fullSquare.GetComponent<SpriteRenderer>().bounds.size.x - square1.GetComponent<SpriteRenderer>().bounds.size.x));

        //The biggest square does not touch the top
        Debug.Log(0.5 * fullSquare.transform.localScale.y);
        Debug.Log(0.5 * square1.transform.localScale.y + 4 * diffY);

        //odd number object color : black -> yellow -> black
        //even number object color : light grey -> heavy grey -> light grey
        //light grey
        //squares[1].GetComponent<Renderer>().material.color = new Color((float)0.5, (float)0.5, (float)0.5, (float)0.5);
        //black
        //squares[2].GetComponent<Renderer>().material.color = new Color(0, 0, 0, 1);
        //heavy grey
        //squares[15].GetComponent<Renderer>().material.color = new Color((float)0.5, (float)0.5, (float)0.5, 1);
        //yellow
        //squares[16].GetComponent<Renderer>().material.color = new Color(1, 1, 0, 1);
        float colorOdd = (float)2 / n;
        float colorEven = (float)1 / n;
        Debug.Log("colorOdd : "+colorOdd);
        Debug.Log("colorEven : "+colorEven);
        //for (int i = 1; i < n; i++)
        //{
        //    squares[i].transform.localScale = squares[i-1].transform.localScale + new Vector3((n - i) * diffX, diffY, 0);
        //    //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
        //    squares[i].transform.position = squares[i-1].transform.position - new Vector3((float)0.5 * (n - i) * diffX, 0, 0);
        //    //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
        //    squares[i].transform.localScale = squares[i].transform.localScale + new Vector3(i * diffX, 0, 0);
        //    //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
        //    //Debug.Log("heyyyyy ");
        //    // transform.position is not accurate.
        //    //why (new Vector3((float)-0.5,0,0) + new Vector3((float)(0.5 * i * diffX), 0, 0) = (-0.5,0,0)
        //    //Debug.Log(squares[i].transform.position + "+" + new Vector3((float)(0.5 * i * diffX), 0, 0) + "=" + (squares[i].transform.position + new Vector3((float)(0.5 * i * diffX), 0, 0)));
        //    //Debug.Log(squares[i].transform.position + "+" + new Vector3((float)(0.5 * i * diffX), 0, 0)+"="+ (new Vector3((float)-0.5,0,0) + new Vector3((float)(0.5 * i * diffX), 0, 0)));
        //    squares[i].transform.position = squares[i].transform.position + new Vector3((float)(0.5 * i * diffX), 0, 0);

        //    //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
        //}

        for (int i = n - 2; i > 0; i--)
        {

            squares[i].transform.localScale = squares[i + 1].transform.localScale - new Vector3(i * diffX, diffY, 0);
            //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
            squares[i].transform.position = squares[i + 1].transform.position + new Vector3((float)0.5 * i * diffX, 0, 0);
            //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
            squares[i].transform.localScale = squares[i].transform.localScale - new Vector3((n - i) * diffX, 0, 0);
            //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
            //Debug.Log("heyyyyy ");
            // transform.position is not accurate.
            //why (new Vector3((float)-0.5,0,0) + new Vector3((float)(0.5 * i * diffX), 0, 0) = (-0.5,0,0)
            //Debug.Log(squares[i].transform.position + "+" + new Vector3((float)(0.5 * i * diffX), 0, 0) + "=" + (squares[i].transform.position + new Vector3((float)(0.5 * i * diffX), 0, 0)));
            //Debug.Log(squares[i].transform.position + "+" + new Vector3((float)(0.5 * i * diffX), 0, 0)+"="+ (new Vector3((float)-0.5,0,0) + new Vector3((float)(0.5 * i * diffX), 0, 0)));
            squares[i].transform.position = squares[i].transform.position - new Vector3((float)(0.5 * (n - i) * diffX), 0, 0);

            //Debug.Log(squares[i].transform.position + " and scale : " + squares[i].transform.localScale);
            if (i < 15)
            {
                if (i % 2 == 0)
                {
                    squares[i].GetComponent<SpriteRenderer>().material.color = new Color(i * colorOdd, i * colorOdd, 0, 1);
                }
                else if (i % 2 == 1)
                {
                    squares[i].GetComponent<SpriteRenderer>().material.color = new Color(1 - i * colorEven, 1 - i * colorEven, 1 - i * colorEven, (float)0.5);
                }
            }
            else if (i >= 15)
            {
                if (i % 2 == 0)
                {
                    squares[i].GetComponent<SpriteRenderer>().material.color = new Color((n - i) * colorOdd,  (n - i) * colorOdd, 0, 1);
                }
                else if (i % 2 == 1)
                {
                    squares[i].GetComponent<SpriteRenderer>().material.color = new Color((float)0.5 + i * colorEven, (float)0.5 + i * colorEven, (float)0.5 + i * colorEven, (float)0.5);
                }
            }
            Debug.Log("i = " + i + "     Color: " + squares[i].GetComponent<SpriteRenderer>().material.color);
        }

        //square1.GetComponent<SpriteRenderer>().material.color = new Color(255, 255, 255, 255);
        // GameObject square = GameObject.Find("square");
        //square.GetComponent<SpriteRenderer>().material.color = new Color(0, 50, 255, 255);
    }
    
    void Update()
    {
        
    }
}

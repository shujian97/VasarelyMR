using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class normalModeButtonScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("normalHomeScene");
    }
}

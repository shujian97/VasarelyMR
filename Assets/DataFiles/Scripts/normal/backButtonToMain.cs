using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButtonToMain : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("startScene");
    }
}

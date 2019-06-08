using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButtonToNormalMode : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("normalHomeScene");
    }
}

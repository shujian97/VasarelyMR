using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class type3Button : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("type3Scene");
    }
}

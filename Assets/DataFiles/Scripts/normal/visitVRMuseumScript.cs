using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class visitVRMuseumScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("VRMuseum");
    }
}

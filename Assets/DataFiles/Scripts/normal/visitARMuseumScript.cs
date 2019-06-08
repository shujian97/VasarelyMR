using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class visitARMuseumScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("ARMuseum");
    }

}

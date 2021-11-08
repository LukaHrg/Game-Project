using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene("Tut_Lvl");
        }
        else if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}

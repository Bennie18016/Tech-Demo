using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuOptions : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("DevMap");
    }

    public void quitGame()
    {
        Application.Quit();
    }


    public void Back()
    {

    }

}

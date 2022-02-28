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
        SaveLoad.SaveGame();
        Application.Quit();
    }

    public void Stats()
    {
        var prefabText = Resources.Load("UI/Text");

        Text title = GameObject.Find("Title").GetComponent<Text>();
        GameObject start = GameObject.Find("Start Game");
        GameObject stats = GameObject.Find("Stats");
        GameObject quit = GameObject.Find("Quit");

        start.SetActive(false);
        stats.SetActive(false);
        quit.SetActive(false);

        GameObject canvas = GameObject.Find("Canvas");
        RectTransform c = canvas.GetComponent<RectTransform>();

        GameObject roundobj = (GameObject)Instantiate(prefabText, new Vector3(0, 0, 0), Quaternion.identity);
        roundobj.transform.SetParent(c);
        Text round = roundobj.GetComponent<Text>();
        RectTransform round_trans = round.GetComponent<RectTransform>();

        title.text = "Your Stats";
        round.text = "Total rounds: " + SaveLoad.savedRounds;

    }

    public void Back()
    {

    }

}

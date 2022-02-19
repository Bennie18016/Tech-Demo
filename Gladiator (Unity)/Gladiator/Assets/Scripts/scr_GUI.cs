using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_GUI : MonoBehaviour
{
    Text RoundText;
    Text CountText;
    GameObject roundstats;
    RoundManager rm;

    private void Start()
    {
        roundstats = GameObject.Find("RoundStats");
        rm = roundstats.GetComponent<RoundManager>();

        var prefabText = Resources.Load("UI/Textround");

        GameObject RoundObj = (GameObject)Instantiate(prefabText, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject CountObj = (GameObject)Instantiate(prefabText, new Vector3(0, 0, 0), Quaternion.identity);

        RoundText = RoundObj.GetComponent<Text>();
        CountText = CountObj.GetComponent<Text>();

        RoundText.transform.SetParent(gameObject.GetComponent<RectTransform>());
        CountText.transform.SetParent(gameObject.GetComponent<RectTransform>());

        RectTransform Count_Trans = CountObj.GetComponent<RectTransform>();
        RectTransform Round_Trans = RoundObj.GetComponent<RectTransform>();

        Count_Trans.anchoredPosition = new Vector3(-440, 240, 0);
        Round_Trans .anchoredPosition = new Vector3(-485, -250, 0);

        Count_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 250f);
    }

    private void Update()
    {
        CountText.text = "Enemies Left: " + rm.EnemyCount;
        RoundText.text = "Round: " + rm.Round;
    }
}

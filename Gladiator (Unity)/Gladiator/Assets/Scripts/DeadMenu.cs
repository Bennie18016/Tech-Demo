using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeadMenu : MonoBehaviour
{

    Text kills;
    Text points;
    Text rounds;
    GameObject em;
    GameObject rm;
    Player e;
    RoundManager r;

    private void Start()
    {
        em = GameObject.Find("EntityManager");
        rm = GameObject.Find("RoundStats");

        e = em.GetComponent<Player>();
        r = rm.GetComponent<RoundManager>();

        var prefabText = Resources.Load("UI/TextRound");

        GameObject KillsObj = (GameObject)Instantiate(prefabText, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject PointsObj = (GameObject)Instantiate(prefabText, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject RoundsObj = (GameObject)Instantiate(prefabText, new Vector3(0, 0, 0), Quaternion.identity);

        kills = KillsObj.GetComponent<Text>();
        points = PointsObj.GetComponent<Text>();
        rounds = RoundsObj.GetComponent<Text>();

        kills.transform.SetParent(gameObject.GetComponent<RectTransform>());
        points.transform.SetParent(gameObject.GetComponent<RectTransform>());
        rounds.transform.SetParent(gameObject.GetComponent<RectTransform>());

        RectTransform Kills_Trans = KillsObj.GetComponent<RectTransform>();
        RectTransform Points_Trans = PointsObj.GetComponent<RectTransform>();
        RectTransform Rounds_Trans = RoundsObj.GetComponent<RectTransform>();

        Kills_Trans.anchoredPosition = new Vector3(0, -25, 0);
        Points_Trans.anchoredPosition = new Vector3(0, -125, 0);
        Rounds_Trans.anchoredPosition = new Vector3(0, -225, 0);

        kills.fontSize = 20;
        points.fontSize = 20;
        rounds.fontSize = 20;

        Kills_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200f);
        Points_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200f);
        Rounds_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200f);
        Kills_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 60f);
        Points_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 60f);
        Rounds_Trans.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 60f);


        kills.text = "Kills: " + e.kills;
        points.text = "Points: " + e.points;
        rounds.text = "Round: " + r.Round;

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void menu()
    {
        SceneManager.LoadScene("Main Menu");
        Destroy(em);
        Destroy(rm);
    }



}

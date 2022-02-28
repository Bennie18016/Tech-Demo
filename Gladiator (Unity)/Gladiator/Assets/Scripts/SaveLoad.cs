using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveLoad : MonoBehaviour
{
    static GameObject rs;
    static GameObject em;
    public static int savedRounds;
    public static int savedKills;
    public static int savedScore;
    public static int savedDeaths;
    static private void Start()
    {
        rs = GameObject.Find("RoundStats");
        em = GameObject.Find("EntityManager");
    }

    public static void SaveGame()
    {
        savedRounds += rs.GetComponent<RoundManager>().Round;
        savedKills += em.GetComponent<Player>().kills;
        savedScore += em.GetComponent<Player>().totscore;
        savedDeaths += em.GetComponent<Player>().deaths;

        PlayerPrefs.SetInt("Rounds", savedRounds);
        PlayerPrefs.SetInt("Kills", savedKills);
        PlayerPrefs.SetInt("Score", savedScore);
        PlayerPrefs.SetInt("Deaths", savedDeaths);
    }

    public static void LoadGame()
    {
        savedRounds = PlayerPrefs.GetInt("Rounds");
        savedKills = PlayerPrefs.GetInt("Kills");
        savedScore = PlayerPrefs.GetInt("Score");
        savedDeaths = PlayerPrefs.GetInt("Deaths");
    }

}

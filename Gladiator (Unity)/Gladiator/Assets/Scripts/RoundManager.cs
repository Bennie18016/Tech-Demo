using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoundManager : MonoBehaviour
{
    GameObject entitymanager;
    Human hu;
    public int Round;
    public int EnemyCount;
    public int[] PreRound12 = { 6, 8, 13, 18, 24, 27, 28, 28, 29, 33, 34 };
    int ran;
    public Vector3[] Spawn_Locations = new[] { new Vector3(25, 1.540848f, 5), new Vector3(0, 1.540848f, 5), new Vector3(18.28f, 1.540848f, 11.23f), new Vector3(5.83f, 1.540848f, 18.58f) };


    private void Start()
    {
        newRoundEnemy();


    }

    private void Update()
    {
        if(EnemyCount == 0)
        {
            newRoundEnemy();
        }
    }

    int newRoundEnemy()
    {
        Round++;

        if (Round < 12)
        {
            EnemyCount = PreRound12[Round - 1];
        }
        else
        {
            EnemyCount = Mathf.RoundToInt(0.0842f * (Mathf.Pow(Round, 2)) + 0.1954f * Round + 22.05f);
        }

        newRoundHealth();
        newRoundSpawn();

        return EnemyCount;
    }


    void newRoundSpawn()
    {
        var prefabHuman = Resources.Load("Models/Exported Enemy (fixed)");
        for (int i = 0; i < EnemyCount; i++)
        {
            ran = Random.Range(0, Spawn_Locations.Length);
            Vector3 zomSpawn = Spawn_Locations[ran];
            GameObject HumanObj = (GameObject)Instantiate(prefabHuman, zomSpawn, Quaternion.identity);
            HumanObj.AddComponent<Human>();


        }
    }

    void newRoundHealth()
    {
        entitymanager = GameObject.Find("EntityManager");
        hu = entitymanager.GetComponent<Human>();

        hu.health += 100;

        if(Round >= 10)
        {
            hu.health *= 1.1f;
        }
    }
}

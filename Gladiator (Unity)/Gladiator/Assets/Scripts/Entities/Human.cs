using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public float health;
    public int strength;
    public float speed;
    GameObject roundstats;
    RoundManager rm;

    private void Start()
    {
        health = 150f;
        strength = 49;
        speed = 4f;
        roundstats = GameObject.Find("RoundStats");
        rm = roundstats.GetComponent<RoundManager>();
    }

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);

            rm.EnemyCount--;
        }
    }
}

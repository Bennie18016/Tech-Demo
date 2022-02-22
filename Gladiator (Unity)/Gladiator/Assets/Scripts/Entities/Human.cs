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
    GameObject entitymanager;
    Human hu;
    Player pl;

    private void Start()
    {
        health = 150f;
        strength = 49;
        speed = 4f;
        roundstats = GameObject.Find("RoundStats");
        rm = roundstats.GetComponent<RoundManager>();
        entitymanager = GameObject.Find("EntityManager");
        hu = entitymanager.GetComponent<Human>();
        pl = entitymanager.GetComponent<Player>();

        health = hu.health;
    }

    private void Update()
    {
        if(health <= 0)
        {
            pl.points += 300;

            Destroy(gameObject);
            rm.EnemyCount--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float maxHP;
    public float health;
    public int strength;
    public int stamina;
    public int points;
    public int kills;
    bool healing;
    Human hu;
    GameObject em;
    GameObject rm;

    private void Start()
    {
        maxHP = 100;
        health = 100f;
        strength = 150;
        stamina = 100;
        points = 0;
        kills = 0;

        em = GameObject.Find("EntityManager");
        rm = GameObject.Find("RoundStats");

    }

    private void Update()
    {

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Dead");
            DontDestroyOnLoad(em);
            DontDestroyOnLoad(rm);
        }

        if (health > maxHP)
        {
            health = maxHP;
        }

        if(health < maxHP)
        {
            if(healing == false)
            {
                StartCoroutine(heal());
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Enemy")
        {
            if (Input.GetMouseButtonDown(0))
            {
                hu = other.GetComponent<Human>();
                hu.health -= strength;
            }
        }


    }

    IEnumerator heal()
    {
        healing = true;
        yield return new WaitForSeconds(2);
        health += 10;
        StartCoroutine(healcool());
    }

    IEnumerator healcool()
    {
        yield return new WaitForSeconds(5);
        healing = false;
    }
}

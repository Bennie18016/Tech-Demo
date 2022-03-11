using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow_Human : Human
{

    Human hu;
    Ent_Behaviour enemy;
    Animator animator;
    Player pl;
    bool inside;
    bool akcool;
    private void Start()
    {
        hu = GameObject.Find("EntityManager").GetComponent<Human>();

        health = hu.health;
        strength = 49;
        speed = 2f;

        enemy = gameObject.GetComponent<Ent_Behaviour>();
        animator = gameObject.GetComponent<Animator>();
        pl = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        enemy.Enemy.speed = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.Play("Attack");
            StartCoroutine(attk());
            inside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inside = false;
        }
    }

    IEnumerator attk()
    {
        yield return new WaitForSeconds(2);
        if (inside == true)
        {
            if (akcool == false)
            {
                pl.health -= strength;
                akcool = true;
                StartCoroutine(attkcool());
            }

        }
    }

    IEnumerator attkcool()
    {
        yield return new WaitForSeconds(3);
        akcool = false;
    }
}


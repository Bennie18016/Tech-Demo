using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float maxHP;
    public float health;
    public int strength;
    public int stamina;
    public int points;
    bool isAttacking;
    Human hu;

    private void Start()
    {
        maxHP = 100f;
        health = 100f;
        strength = 150;
        stamina = 100;
        points = 0;
    }

    private void Update()
    {
        isAttacking = Input.GetMouseButtonDown(0);

        if(health <= 0)
        {
            Destroy(gameObject);
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
}

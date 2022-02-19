using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float health;
    public int strength;
    public int stamina;
    bool isAttacking;
    Human hu;

    private void Start()
    {
        health = 100f;
        strength = 150;
        stamina = 100;
    }

    private void Update()
    {
        isAttacking = Input.GetMouseButtonDown(0);
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Enemy")
        {
            hu = other.GetComponent<Human>();
            Debug.Log("Test");
            Debug.Log(hu.health);
            hu.health -= strength;
        }

    }



}

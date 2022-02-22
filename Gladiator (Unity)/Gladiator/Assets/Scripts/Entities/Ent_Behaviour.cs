using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   

public class Ent_Behaviour : MonoBehaviour
{
    GameObject Player;
    NavMeshAgent Enemy;
    GameObject entitymanager;
    Human hu;

    private void Start()
    {
        entitymanager = GameObject.Find("EntityManager");
        hu = entitymanager.GetComponent<Human>();

        Enemy = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Enemy.stoppingDistance = 2.8f;
        Enemy.speed = hu.speed;
    }
    private void Update()
    {
        Enemy.SetDestination(Player.transform.position);

    }

    

}

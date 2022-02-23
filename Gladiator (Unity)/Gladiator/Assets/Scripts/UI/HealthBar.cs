using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    Slider HBar;
    GameObject pl_obj;
    Player pl_scr;

    void Start()
    {
        pl_obj = GameObject.FindGameObjectWithTag("Player");
        pl_scr = pl_obj.GetComponent<Player>();
        HBar = this.GetComponent<Slider>();

        HBar.maxValue = pl_scr.maxHP;
        HBar.minValue = 0;  
    }

    void Update()
    {
        HBar.value = pl_scr.health;
    }

}

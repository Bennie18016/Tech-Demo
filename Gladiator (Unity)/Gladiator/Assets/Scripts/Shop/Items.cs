using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum Item
    {
        Mace,
        Sword,
        HealthPotion
    }

    public static int GetCost(Item item)
    {
        switch (item)
        {
            default:
            case Item.Mace: return 10000;
            case Item.Sword: return 25000;
            case Item.HealthPotion: return 5000;    
        }
    }

}
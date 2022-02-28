using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public enum Item
    {
        Mace,
        Fireball,
        Sword,
        HealthPotion
    }

    public static int GetCost(Item item)
    {
        switch (item)
        {
            default:
            case Item.Mace: return 10000;
            case Item.Fireball: return 12500;
            case Item.Sword: return 25000;
            case Item.HealthPotion: return 5000;    
        }
    }

}

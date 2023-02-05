using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Currency s_coins;

    public static void AddCoins(double coins)
    {
        s_coins += coins;
    }

    public static void RemoveCoins(double coins)
    {

        s_coins -= coins;
    }
}

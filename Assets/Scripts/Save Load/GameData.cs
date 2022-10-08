using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    //[SerializeField] private int hp;
    [SerializeField] private int coins;

    public GameData()
    {
        //this.isRaining = false;
        //this.hp = 100;
        this.coins = 0;
    }

    public int GetCoins()
    {
        return coins;
        //return this.isRaining;
    }

    /*public int GetHP()
    {
        return hp;
    }
    public void SetHP(int num)
    {
        hp = num;
    }*/

    public void SetCoins(int num)
    {
        coins = num;
    }
}

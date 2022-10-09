using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Balls
{
    basic,    fuego,    pokemon,    patron1,    patron2,
    basket,    bowling,    mina,    dragon,     verde
}

public class GameData : MonoBehaviour
{
    //[SerializeField] private int hp;
    [SerializeField] private int coins;
    [SerializeField] private List<bool> ballsUnlocked;
    [SerializeField] private Balls ballSelected;
    [SerializeField] private int levelsBeat;


    public GameData()
    {
        //this.isRaining = false;
        //this.hp = 100;
        this.coins = 0;
    }

    public int GetCoins()
    {
        return coins;
    }

    public void LevelBeaten(int lvlBeaten)
    {
        levelsBeat = lvlBeaten;
    }
    public int GetLevelsBeat()
    {
        return levelsBeat;
    }

    public void UnlockBall(int newBallIndex)
    {
        ballsUnlocked[newBallIndex] = true;
    }
    public bool CheckIfBallUnlocked(int ballIndex)
    {
        return ballsUnlocked[ballIndex];
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

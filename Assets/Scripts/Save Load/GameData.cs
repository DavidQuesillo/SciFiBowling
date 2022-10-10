using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    //[SerializeField] private int hp;
    [SerializeField] private int coins;
    [SerializeField] private List<Balls> ballsUnlocked;
    [SerializeField] private Balls selectedBall;
    //[SerializeField] private Balls ballSelected;
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
    public Balls GetSelectedBall()
    {
        return selectedBall;
    }
    public void SetSelectedBall(Balls newBall)
    {
        selectedBall = newBall;
    }

    public void UnlockBall(int newBallId)
    {
        for (int i = 0; i < ballsUnlocked.Count; i++)
        {
            if (ballsUnlocked[i].id == newBallId)
            {
                ballsUnlocked[i].isUnlocked = true;
            }
        }
        //ballsUnlocked[newBallIndex].isUnlocked = true;
    }
    public bool CheckIfBallUnlocked(int ballId)
    {
        for (int i = 0; i < ballsUnlocked.Count; i++)
        {
            if (ballsUnlocked[i].id == ballId && ballsUnlocked[i].isUnlocked)
            {
                return true;                
            }
        }
        return false;
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

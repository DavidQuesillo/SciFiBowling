using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    //[SerializeField] private int hp;
    [SerializeField] private int coins;
    [SerializeField] public List<Balls> ballsUnlocked;
    [SerializeField] private Balls selectedBall;
    [SerializeField] private GameObject defaultBall;
    //[SerializeField] private Balls ballSelected;
    [SerializeField] private int levelsBeat = 0;


    public GameData()
    {
        //this.isRaining = false;
        //this.hp = 100;
        this.coins = 0;
    }

    /*private void Awake()
    {
        for (int i = 0; i < ballsUnlocked.Count; i++)
        {

        }
    }*/

    public int GetCoins()
    {
        return coins;
    }

    public void LevelBeaten(int lvlBeaten)
    {
        levelsBeat = lvlBeaten;
        Data.Save();
    }
    public int GetLevelsBeat()
    {
        return levelsBeat;
    }
    public void SetBallsList(List<Balls> newList)
    {
        ballsUnlocked = newList;
    }
    public Balls GetSelectedBall()
    {
        if (selectedBall != null)
        {
            return selectedBall;
        }
        else
        {
            selectedBall = defaultBall.GetComponent<Balls>();
            return defaultBall.GetComponent<Balls>();
        }
    }
    public void SetSelectedBall(Balls newBall)
    {
        selectedBall = newBall;
        Data.Save();
    }

    /*public List<Balls> GetBallsList()
    {
       return  ballsUnlocked;
    }*/

    public void UnlockBall(int newBallId)
    {
        for (int i = 0; i < ballsUnlocked.Count; i++)
        {
            if (ballsUnlocked[i].id == newBallId)
            {
                ballsUnlocked[i].isUnlocked = true;
            }
        }
        Data.Save();
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

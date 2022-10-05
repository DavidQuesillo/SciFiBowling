using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int coins;
    [SerializeField] private int goldTotal;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this; //gamemanager.instance se asigna a este script en este objeto en el juego
        }        
    }

    void Update()
    {
        
    }

    public void PickUpCoin() //recoger moneda
    {
        Debug.Log("Picked up coin");
        coins += 1;
    }
    public void PickUpGold() //recoger pinos de oro
    {
        goldTotal += 1;
    }

    public void RetryLevel() //código placeholder adentro
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SaveValues()
    {
        Data.GetGameData().SetCoins(coins);
        //Data.GetGame().SetHP(player.GetHealth());

        Data.Save();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private int coins;
    [SerializeField] private int goldTotal;

    private void Awake()
    {
        /*if (Data.GetGameData().GetSelectedBall() != null)
        {
            Debug.Log(Data.GetGameData().GetSelectedBall().gameObject.name);
            GameObject playerball = Instantiate(Data.GetGameData().GetSelectedBall().gameObject);
            Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Follow = playerball.transform;
            Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.LookAt = playerball.transform;
        }
        else
        {
            Debug.Log("ERRORRRR");
        }*/

        //GameObject playerball = GameObject.FindGameObjectWithTag("Player");
        //Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.Follow = playerball.transform;
        //Camera.main.GetComponent<CinemachineBrain>().ActiveVirtualCamera.LookAt = playerball.transform;
    }

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
    public void LoadLevel(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void SaveValues()
    {
        Data.GetGameData().SetCoins(+coins);
        //Data.GetGame().SetHP(player.GetHealth());

        Data.Save();
    }
}

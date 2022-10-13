using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject LevelSelect;
    [SerializeField] private GameObject BallSelect;
    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject Victory;
    [SerializeField] private GameObject Title;
    [SerializeField] private GameObject currentActive;

    public void ViewLevelSelect()
    {
        currentActive.SetActive(false);
        LevelSelect.SetActive(true);
        currentActive = LevelSelect;
        Debug.Log("Button pressed");
    }
    public void ViewBallSelect()
    {
        currentActive.SetActive(false);
        BallSelect.SetActive(true);
        currentActive = BallSelect;
    }
    public void ViewGameOver()
    {
        currentActive.SetActive(false);
        GameOver.SetActive(true);
        currentActive = GameOver;
    }
    public void ViewVictory()
    {
        currentActive.SetActive(false);
        Victory.SetActive(true);
        currentActive = Victory;
    }
    public void ViewTitle()
    {
        currentActive.SetActive(false);
        Title.SetActive(true);
        currentActive = Title;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

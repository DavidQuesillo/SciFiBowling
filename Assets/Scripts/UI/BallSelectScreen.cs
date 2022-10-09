using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSelectScreen : MonoBehaviour
{
    [SerializeField] private int selectedBall;
    //[SerializeField] private int currentId;
    [SerializeField] private Image preview;
    [SerializeField] private Image accelMeter;
    [SerializeField] private Image speedMeter;
    [SerializeField] private Image bounceMeter;
    //[SerializeField] private Sprite[] ballIcons = new Sprite[10];
    [SerializeField] private List<Balls> balls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseBall(int newBallID)
    {
        if (balls[selectedBall].id != newBallID)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].id == newBallID)
                {
                    selectedBall = i;
                }
            }
            DisplayBallInfo();
            //selectedBall = newBallID;
            Debug.Log("ball chosen");
        }
        Debug.Log("Button pressed");
    }

    public void DisplayBallInfo()
    {
        preview.sprite = balls[selectedBall].icon;
        accelMeter.fillAmount = balls[selectedBall].accelStat;
        speedMeter.fillAmount = balls[selectedBall].maxSpeedStat;
        bounceMeter.fillAmount = balls[selectedBall].bounceStat;
    }
}

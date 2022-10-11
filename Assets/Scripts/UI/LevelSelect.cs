using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private List<GameObject> lvlsDisplay;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lvlsDisplay.Count; i++)
        {
            int lvls = Data.GetGameData().GetLevelsBeat();
            if (i <= lvls)
            {
                lvlsDisplay[i].GetComponent<Image>().enabled = false;
                lvlsDisplay[i].GetComponent<Button>().enabled = true;
                lvlsDisplay[i].GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            }
            else
            {
                lvlsDisplay[i].GetComponent<Image>().enabled = true;
                lvlsDisplay[i].GetComponent<Button>().enabled = false;
                lvlsDisplay[i].GetComponentInChildren<TextMeshProUGUI>().enabled = false;
            }
        }
    }

    public void LoadLevel(int levelIndex)
    {
        GameManager.instance.LoadLevel(levelIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

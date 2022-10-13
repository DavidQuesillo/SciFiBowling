using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum musicStates { NonGameplay, Gameplay, PostGame }
public class MusicManager : MonoBehaviour
{
    [SerializeField] private AudioClip gameMusic;
    [SerializeField] private AudioClip menuMusic;
    [SerializeField] private AudioSource aus;
    private musicStates status;
    public static MusicManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ChangeState(musicStates newState)
    {
        switch (newState)
        {
            case musicStates.NonGameplay:
                aus.Stop();
                aus.clip = menuMusic;
                aus.volume = 0.4f;
                aus.Play();
                status = newState;
                break;
            case musicStates.Gameplay:
                if (status == musicStates.NonGameplay)
                {
                    aus.Stop();
                }                
                aus.clip = gameMusic;
                aus.volume = 0.4f;
                aus.Play();
                status = newState;
                break;
            case musicStates.PostGame:
                aus.volume = 0.1f;
                status = newState;
                break;
            default:
                break;
        }
    }
}

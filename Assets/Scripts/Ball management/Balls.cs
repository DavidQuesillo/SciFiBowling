using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Balls : MonoBehaviour
{
    public int id;
    public string ballName;
    public int price;
    public bool isUnlocked;
    public Sprite icon;
    [Header("Poner entre 0 y 1 para el fill de la barra. Los factores de gameplay son variables en el prefab player")]
    public float accelStat; //sideswipeforce
    public float maxSpeedStat; //maxspeed
    public float bounceStat; //physic material
}

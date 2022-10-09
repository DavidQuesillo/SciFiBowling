using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public int id;
    public string ballName;
    public int price;
    public bool isUnlocked;
    public Sprite icon;
    [Header("Poner entre 0 y 1 para el fill de la barra")]
    public float accelStat;
    public float maxSpeedStat;
    public float bounceStat;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pendulo : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float duracion = 1f;
    [Tooltip("Poner negativo de la rotacion Z inicial")] [SerializeField] private float angle = -60f;

    // Start is called before the first frame update
    void Start()
    {
        rb.DORotate(Vector3.forward * angle, duracion, RotateMode.Fast).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

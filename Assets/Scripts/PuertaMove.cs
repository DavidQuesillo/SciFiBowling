using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PuertaMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Transform puntoFin;    
    [SerializeField] private float duracion = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        rb.DOMove(puntoFin.position, duracion).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

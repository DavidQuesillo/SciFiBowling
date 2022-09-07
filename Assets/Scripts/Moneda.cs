using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Moneda : MonoBehaviour
{
    [SerializeField] private float rotateDuration = 20f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Rigidbody>().DORotate(Vector3.up * 360, rotateDuration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.PickUpCoin();
            gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Puas : MonoBehaviour
{

    [SerializeField] private Transform ptr;
    [SerializeField] private float loopTime = 1f;
    [SerializeField] private Collider killColl;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PuasLoop());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator PuasLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(loopTime);
            ptr.DOMoveY(-0.7f, 0.1f);
            killColl.enabled = false;
            yield return new WaitForSeconds(loopTime);            
            ptr.DOMoveY(0.127f, 0.1f);
            killColl.enabled = true;
        }
    }
}

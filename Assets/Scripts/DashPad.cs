using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashPad : MonoBehaviour
{
    [SerializeField] private float minSpeed = 5f;
    [SerializeField] private float speedBoost = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<Rigidbody>().velocity.magnitude < minSpeed)
            {
                other.GetComponent<Rigidbody>().velocity = transform.forward * (minSpeed + speedBoost);
            }
            else
            {
                other.GetComponent<Rigidbody>().velocity = transform.forward * (other.GetComponent<Rigidbody>().velocity.magnitude * speedBoost);
            }
        }
    }
}

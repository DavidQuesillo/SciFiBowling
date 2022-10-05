using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private bool stageComplete;
    public bool gameStarted; //distingue si la partida se ha iniciado, si se ha lanzado la bola aún o no
    [SerializeField] private float killHeight = -5f;
    [Tooltip("La fuerza con la que se empuja a la bola al hacer swipe durante la partida")] [SerializeField] private float sideSwipeForce = 5f;
    [Tooltip("La fuerza con la que se lanza la bola inicialmente")] [SerializeField] private float launchForce = 5f;
    public Vector3 launchVector; //el vector que le da la fuerza y dirección al lanzamiento inicial
    public Vector3 speed;
    public float totalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //StartCoroutine(AutoKeepMoving());
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity;
        totalSpeed = rb.velocity.magnitude;
        if (rb.position.y <= killHeight)
        {
            PlayerDeath();
        }
    }
    private void PlayerDeath()
    {
        GameManager.instance.RetryLevel(); //llama la función del gamemanager de gameover
    }

    public void BuildLaunchForce(Vector3 launcherPos) //recibe la información del dedo para medir el vector de fuerza para el lanzamiento inicial
    {
        launchVector = new Vector3(rb.position.x - launcherPos.x, 0f, Mathf.Clamp(rb.position.z - launcherPos.z, -2f, 2f));
        //rb.AddForce(launcherPos - rb.position, ForceMode.Impulse);
        //StartCoroutine(AutoKeepMoving());
    }
    public void LaunchBall() //le da la fuerza al jugador cuando se lanza inicialmente la bola
    {
        if (!gameStarted)
        {
            rb.AddForce(launchVector * launchForce, ForceMode.Impulse);
            StartCoroutine(AutoKeepMoving());
            gameStarted = true;
        }        
    }
    public void PushForce(Vector2 force) //le añade fuerza al jugador hacia un swipe durante la partida
    {
        if (gameStarted)
        {
            rb.AddForce(new Vector3(force.x * sideSwipeForce, 0f, force.y), ForceMode.Force);
        }        
    }

    private IEnumerator AutoKeepMoving() //le aplica una fuerza al jugador cuando su velocidad pasa bajo un umbral para que se siga moviendo
    {
        while (!stageComplete)
        {
            if (rb.velocity.z < 5f) //la velocidad mínima del jugador
            {
                rb.AddForce(Vector3.forward * 2f, ForceMode.Force); //le añade fuerza hasta que se pase sobre el mínimo puesto arriba
                yield return null;
            }
            else
            {
                yield return null;
            }
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillPlayer"))
        {
            PlayerDeath();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.CompareTag("BreakBlock"))
        {
            collision.gameObject.SetActive(false);
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PuertaAbreCierra : MonoBehaviour
{
    [SerializeField] private Rigidbody puertaL, puertaR;
    [SerializeField] private bool iniciarCerrado = false;
    [Tooltip("Cuan rápido o lento la puerta se abre o cierra")] [SerializeField] private float duracionAnim = 0.8f;
    [Tooltip("Cuanto tiempo tiene que pasar para que la puerta vuelva a abrirse/cerrarse, en segundos")] [SerializeField] private float tiempoAbrirCerrar = 1f;
    [Tooltip("La distancia inicial entre las puertas y el centro")] [SerializeField] private float distanciaPuertasDeCentro = 3f;

    // Start is called before the first frame update
    void Start()
    {
        if (!iniciarCerrado)
        {
            puertaL.position = transform.position + Vector3.left * distanciaPuertasDeCentro + Vector3.up;
            puertaR.position = transform.position + Vector3.right * distanciaPuertasDeCentro + Vector3.up;
        }
        else
        {
            puertaL.position = transform.position + Vector3.left * 0.1f + Vector3.up;
            puertaR.position = transform.position + Vector3.right * 0.1f + Vector3.up;
        }
        StartCoroutine(AbrirCerrarCiclo());
        //puertaL.DOMove(transform.position + Vector3.left * 0.1f + Vector3.up, duracionAnim).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        //puertaR.DOMove(transform.position + Vector3.right * 0.1f + Vector3.up, duracionAnim).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator AbrirCerrarCiclo()
    {
        if (iniciarCerrado)
        {
            yield return new WaitForSeconds(tiempoAbrirCerrar);
            puertaL.DOMove(transform.position + Vector3.left * distanciaPuertasDeCentro + Vector3.up, duracionAnim).SetEase(Ease.InOutSine);
            puertaR.DOMove(transform.position + Vector3.right * distanciaPuertasDeCentro + Vector3.up, duracionAnim).SetEase(Ease.InOutSine);
        }
        while (true)
        {
            yield return new WaitForSeconds(tiempoAbrirCerrar);
            puertaL.DOMove(transform.position + Vector3.left * 0.1f + Vector3.up, duracionAnim).SetEase(Ease.InOutSine);
            puertaR.DOMove(transform.position + Vector3.right * 0.1f + Vector3.up, duracionAnim).SetEase(Ease.InOutSine);
            yield return new WaitForSeconds(tiempoAbrirCerrar);
            puertaL.DOMove(transform.position + Vector3.left * distanciaPuertasDeCentro + Vector3.up, duracionAnim).SetEase(Ease.InOutSine);
            puertaR.DOMove(transform.position + Vector3.right * distanciaPuertasDeCentro + Vector3.up, duracionAnim).SetEase(Ease.InOutSine);
        }
    }
}

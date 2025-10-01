using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour

{
    public float speed;

    public Transform particulas;

    public Text textoContador;

    public Text textoGanar;

    private int contador;

    private ParticleSystem sistemaParticulas;

    private Vector3 posicion;

    private Rigidbody rb;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movimiento * speed);

    }

    void Start()
    {
        sistemaParticulas = particulas.GetComponent<ParticleSystem>();

        sistemaParticulas.Stop();

        rb = GetComponent<Rigidbody>();   

        textoContador.text = "Contador: " + contador.ToString();

        textoGanar.text = "";
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(contador >= 11){
            textoGanar.text = "¡¡Has Ganado!!";
        }

        if (other.gameObject.CompareTag("Recolectable")){
            other.gameObject.SetActive(false);
            contador = contador + 1;
            textoContador.text = "Contador: " + contador.ToString();
        } else {

            //No es recolectable

        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Material material;

    private Vector3 posicionInicial;
    private Vector3 escalaInicial;

    void Start()
    {
        material = GetComponent<Renderer>().material;
        material.color = Color.black;
        posicionInicial = transform.position;
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        
    }

    public void CambiarColor(int opcion){

        Debug.Log ("parametro:" + opcion);
        switch (opcion){
            case 0:
                Debug.Log ("Opcion 1");
                material.color = Color.black;
                break;
            case 1:
                Debug.Log ("Opcion 2");
                material.color = Color.red;
                break;
            case 2:
                Debug.Log ("Opcion 3");
                material.color = Color.yellow;
                break;
        }
    }

    public void RotarCubo(){
        transform.Rotate (new Vector3 (45, 45, 45));
    }

    public void EscalarCubo(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    public void MoverX(float value)
    {
        transform.position = new Vector3(posicionInicial.x + value, transform.position.y, transform.position.z);
    }

    public void MoverY(float value)
    {
        transform.position = new Vector3(transform.position.x, posicionInicial.y + value, transform.position.z);
    }

    public void MoverZ(float value)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, posicionInicial.z + value);
    }

    public void ReiniciarCubo()
    {
        transform.position = posicionInicial;
        transform.localScale = escalaInicial;
        material.color = Color.black;
    }
}

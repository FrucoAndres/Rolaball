using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirApp : MonoBehaviour
{

    public void SalirAplicacion(){
        
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

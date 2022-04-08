using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public int edad = 16;
    public Text mitexto;
    void Start()
    {
        
        if (edad>= 18)
        {
            mitexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            mitexto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

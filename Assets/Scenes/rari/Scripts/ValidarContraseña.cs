using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    // Start is called before the first frame update

    string contraseñaCorrecta;
    string ContraseñaUsuario;
    public Text ingresoUsuario;

    void Start()
    {
        contraseñaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContraseña()
    {
        ContraseñaUsuario = ingresoUsuario.text;
        
        if (contraseñaCorrecta == ContraseñaUsuario)
        {
            Debug.Log("Bienvenido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}

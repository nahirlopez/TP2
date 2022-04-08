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
    public Text textomsj;
    public GameObject cartelitoMsj;

    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
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
            cartelitoMsj.SetActive(true);
            textomsj.text = "Bienvenido";
        }
        else
        {
            cartelitoMsj.SetActive(true);
            Debug.Log("Contraseña incorrecta");
            textomsj.text = "Contraseña incorrecta";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    public string nombreAlumno="";
    public int anio;
    public string orientacion; // T D G M H
    // Start is called before the first frame update
    void Start()
    {
        bool todoOK = true;
        if (nombreAlumno == "")
        {
            Debug.Log("Error, el nombre no puede estar vacío");
            todoOK = false;
        }

        if (anio < 1 || anio > 5)
        {
            Debug.Log("Error, el año ingresado no es válido.");
            todoOK = false;
        }

        if (orientacion != "T" && orientacion != "D" && orientacion != "G" && orientacion != "M" && orientacion != "H")
        {
            Debug.Log("Error, la orientación ingresada no es válida");
            todoOK = false;
        }

        if (todoOK)
        {
            Debug.Log(" “Muchas gracias "+nombreAlumno+"!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

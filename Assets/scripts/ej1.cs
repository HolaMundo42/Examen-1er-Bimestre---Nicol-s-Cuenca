using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    public string nombreAlumno = "";
    public int anio;
    public string orientacion; // T D G M H

    void Start()
    {
        orientacion = orientacion.ToUpper();
        //bool todoOK = true;
        if (nombreAlumno == "")
        {
            Debug.Log("Error, el nombre no puede estar vacío");
            return;
        }

        else if (anio < 1 || anio > 5)
        {
            Debug.Log("Error, el año ingresado no es válido.");
            return;
        }

        else if (anio == 1 || anio == 2)
        {
            Debug.Log("Error, estás en ciclo básico.");
            return;
        }

        else if (orientacion != "T" && orientacion != "D" && orientacion != "G" && orientacion != "M" && orientacion != "H")
        {
            Debug.Log("Error, la orientación ingresada no es válida");
            return;
        }
        Debug.Log(" “Muchas gracias "+nombreAlumno+"!");


    }
}

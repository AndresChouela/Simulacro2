using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema2 : MonoBehaviour
{
    public string nombrealumno;
    public string especialidad;
    public int anio;
    // Start is called before the first frame update
    void Start()
    {
        if(anio >= 5 || anio <= 1)
        {
            Debug.Log("Error, año ingresado no valido");
        }
        else
        {
            if(anio == 1 || anio == 2)
            {
                Debug.Log("Error. Aún estás en el ciclo básico");
            }
            else
            {
                if(especialidad == "T" || especialidad == "D" || especialidad == "H" || especialidad == "M" || especialidad == "G")
                {
                    Debug.Log("Muchas gracias" + nombrealumno + "!");
                }
                else
                {
                    Debug.Log("Solo puede ingresar T, D, G, M o H");
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

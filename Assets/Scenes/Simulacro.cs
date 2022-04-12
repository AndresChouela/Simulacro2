using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro : MonoBehaviour
{
    public float montototal;
    float valordolar = 112;
    float valoreuro = 122;
    float valorreal = 24;
    public string moneda;
    float cantidadconvertida;
    // Start is called before the first frame update
    void Start()
    {
        if(montototal < 1000)
        {
            Debug.Log("El monto minimo es $1000");
        }
        else
        {
            switch (moneda)
            {
                case "D":
                    cantidadconvertida = montototal / valordolar;
                    Debug.Log(montototal + " pesos argentinos equivalen a " + cantidadconvertida + " Dolares");
                    break;
                case "E":
                    cantidadconvertida = montototal / valoreuro;
                    Debug.Log(montototal + " pesos argentinos equivalen a " + cantidadconvertida + " Euros");
                    break;
                case "R":
                    cantidadconvertida = montototal / valorreal;
                    Debug.Log(montototal + " pesos argentinos equivalen a " + cantidadconvertida + " Reales");
                    break;
                default:
                    Debug.Log("Opcion de moneda extranjera no valida");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos
//y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto 
//de dinero disponible. Luego indicar cuánto dinero sobra o falta.
public class Ej_2 : MonoBehaviour
{
    public int producto1;
    public int producto2;
    public int producto3;
    public int dinerodisponible;
    // Start is called before the first frame update
    void Start()
    {
        int resto;
        int monto;
        monto = producto1 + producto2 + producto3;
     if(producto1 + producto2 + producto3 > dinerodisponible)
        {
            Debug.Log("El precio de los tres productos supera el dinero disponible");
        }
        else
        {
            Debug.Log("El precio de los tres productos no supera el dinero disponible");
        }
        resto = dinerodisponible - monto;
        if(resto < monto)
        {
            Debug.Log("Sobran" +resto+ "pesos");
        }
        else if (resto > monto)
        {
            Debug.Log("Faltan" +resto+ "pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{

    public int Num1;
    public int Num2;

    // Start is called before the first frame update
    void Start()
    {
        //escribir los enteros desde 0 hasta al 4
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        for ( int i = 6; i <= 31; i+=3)
        {
            Debug.Log(i);
        }

        //escribir los enteros desde 0 hasta 50 excepto los múltiplos de 7
        for (int i = 0; i <= 50; i++) 
        {
            if(i % 7 != 0)
            {
                Debug.Log(i);
            }
        }

        //escribir los enteros entre dos enteros ingresados por inpector (NO inclusive)
        for( int i = Num1; i < Num2; i++)
        {
            Debug.Log(i);
        }

        // escribir los enteros entre 100 y 0 (inclusive) de manera descendente
        for (int i = 100; i >= 0; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

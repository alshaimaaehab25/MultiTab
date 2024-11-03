using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
     int Multiplication(int a, int b)
    {
        return a * b;
    }
    // Start is called before the first frame update
    void Start()
    {
         for (int i = 1; i <= 10; i++)
        {
            int result = Multiplication(5, i);
            Debug.Log("5 x " + i + " = " + result);
        }
    }
 }

 
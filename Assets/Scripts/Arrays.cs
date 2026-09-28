using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] edades = new int[4];

    bool TodosIguales = false;
    int CantidadRepeticiones = 0;
    // Start is called before the first frame update
    void Start()
    {
        edades[0] = Random.Range(0, 11);
        edades[2] = 46;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ClearArray(edades);
        }
        if (Input.GetKeyDown(KeyCode.S))
        { 
            SquareOfIndex(edades); 
        }
        
        TodosIguales = SonIguales(edades);
        if (!TodosIguales)
        {
            CantidadRepeticiones++;
            RandomNumbers(edades);
        }
        else
        {
            Debug.Log(CantidadRepeticiones);
        } 
    }

    void ClearArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }

    void SquareOfIndex(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * i;
        }
    }

    void RandomNumbers(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 3);
        }
    }

    bool SonIguales(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != array[0])
            {
                return false;
            }
        }

        return true;
    }
}

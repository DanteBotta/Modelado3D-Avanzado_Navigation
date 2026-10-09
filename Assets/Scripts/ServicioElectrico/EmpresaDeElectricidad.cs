using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EmpresaDeElectricidad : MonoBehaviour
{
    public Domicilio[] domicilios;

    // Start is called before the first frame update
    void Start()
    {
        domicilios = FindObjectsOfType<Domicilio>();

        for (int i = 0; i <domicilios.Length; i++)
        {
            domicilios[i].servicioElectricoActivo = UnityEngine.Random.value < 0.5f;
            domicilios[i].luzDomicilio.SetActive(domicilios[i].servicioElectricoActivo);
        }
        //Para cada domicilio generar y asignar aleatoriamente un valor booleano 
        // para su propiedad servicioElectricoActivo
        //Para cada domicilio, activar o desactivar el objeto luz 
        // de acuerdo a si la propiedad servicioElectricoActivo es verdadero o falso, respectivamente.         

        MostrarInfoEnConsola();
    }

    // Update is called once per frame
    void Update()
    {
        //Tecla C (CORTE): apaga todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (Domicilio domicilio in domicilios)
            {
                domicilio.luzDomicilio.SetActive(false);
            }
        }
        //Tecla R(RESTITUCION): enciende las luces solo de los domicilios 
        // con servicioElectricoActivo verdadero
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (Domicilio domicilio in domicilios)
            {
                domicilio.luzDomicilio.SetActive(domicilio.servicioElectricoActivo);
            }
        }
        //Tecla T(TODOS): enciende todas las luces de todos los domicilios 
        // independientemente del valor de la propiedad servicioElectricoActivo
        if (Input.GetKeyDown(KeyCode.T))
        {
            foreach (Domicilio domicilio in domicilios)
            {
                domicilio.luzDomicilio.SetActive(true);
            }
        }
    }

    void MostrarInfoEnConsola()
    {
        int cantidad = 0;
        float porcentaje = 0;
        int totalCasas = domicilios.Length;
        foreach (Domicilio domicilio in domicilios)
        {
            if (domicilio.servicioElectricoActivo)
            {
                cantidad++;
            }
        }
        porcentaje = (float)cantidad / totalCasas * 100;

        Debug.Log("Hay " + cantidad + " de casas con el servicio eléctrico activo");
        Debug.Log("El " + porcentaje + "% de las casas tienen servicio eléctrico activo");
        //cuántos domicilios tienen su servicio eléctrico activo
        // porcentaje de domicilios con servicio eléctrico activo
    }
}

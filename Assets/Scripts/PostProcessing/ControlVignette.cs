using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ControlVignette : MonoBehaviour
{
    public PostProcessVolume volumenEfectos;
    private Vignette Vignette;

    // Start is called before the first frame update
    void Start()
    {
        volumenEfectos = FindObjectOfType<PostProcessVolume>();
        volumenEfectos.profile.TryGetSettings(out Vignette);
    }

    public void CambiarIntensidadVignette(float intencidad)
    {
        if (Vignette != null)
        {
            Vignette.intensity.overrideState = true;
            Vignette.intensity.value = intencidad;
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CambiarIntensidadVignette(0f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CambiarIntensidadVignette(0.1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CambiarIntensidadVignette(0.2f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CambiarIntensidadVignette(0.3f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CambiarIntensidadVignette(0.4f);
        }
    }
}

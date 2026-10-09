using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPostProcessing : MonoBehaviour
{
    public ControlVignette ControlVignette;

    // Start is called before the first frame update
    void Start()
    {
        ControlVignette = FindObjectOfType<ControlVignette>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

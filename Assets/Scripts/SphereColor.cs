using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColor : MonoBehaviour
{

    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = color;
        
    }
}

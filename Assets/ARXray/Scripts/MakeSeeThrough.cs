using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSeeThrough : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.renderQueue = 3002;
        
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenMoving : MonoBehaviour
{

    public Vector3 transformation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transformation;
    }
}

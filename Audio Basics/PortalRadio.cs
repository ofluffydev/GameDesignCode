using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRadio : MonoBehaviour
{

    public Vector3 transformationPortal;
    public Vector3 rotationValPortal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transformationPortal;
        transform.rotation *= Quaternion.Euler(rotationValPortal);
    }
}

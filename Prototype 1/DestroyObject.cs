using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Destroy any game objects when out of view that have this script
    // Variables:
    
    public float topBound = 30;
    public float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy when out of view each game object when out of z range (off screen) so that there isn't infinite game objects slowing the computer down
        if (transform.position.z > topBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}

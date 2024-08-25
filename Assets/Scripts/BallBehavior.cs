using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // add initial velocit
        GetComponent<Rigidbody2D>().AddForce( new Vector2(500f, 500f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerBehaviorCW : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, -390f * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcontroller : MonoBehaviour
{
    public float dropSpeed = -0.03f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, dropSpeed, 0);

        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}

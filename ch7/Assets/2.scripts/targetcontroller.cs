using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetcontroller : MonoBehaviour
{
    Transform PlaterTR;
    generatetarget gt;
    // Start is called before the first frame update
    void Start()
    {
        gt = GameObject.FindAnyObjectByType<generatetarget>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(PlaterTR);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        gt.GenerateTargetObject();
    }
}

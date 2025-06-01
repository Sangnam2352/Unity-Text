using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    float power = 0f;
    float startVal = 0f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startVal = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startVal;
            GameObject bamsongi = Instantiate(bamsongiPrefab);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 worldDir = ray.direction;
            // bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized * 2000);
            bamsongi.GetComponent<BamsongiController>().
                 Shoot((transform.forward + transform.up *0.5f).normalized * power * 9);
        }
    }
}
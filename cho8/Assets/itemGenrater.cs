using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenrater : MonoBehaviour
{
    public GameObject appleprefab;
    public GameObject bombprefab;

    float span = 1f;
    float delta = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if(delta > span)
        {
            Instantiate(appleprefab, transform.position, transform.rotation);
            delta = 0;
        }
    }
}

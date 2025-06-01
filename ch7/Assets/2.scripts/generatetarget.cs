using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatetarget : MonoBehaviour
{
    public GameObject targetPrefab;
    float minDistance = 10;
    Transform player;

    Transform[] destinations;
    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>();
        Debug.Log("Num of children : " + destinations.Length);
        player = GameObject.Find("Cube").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GenerateTargetObject()
    {
        int index;
        Vector3 position;


        do
        {
            index = Random.Range(1, destinations.Length);
            position = destinations[index].position;
        } while (Vector3.Distance(position, player.position) < minDistance);

        index = Random.Range(1, destinations.Length);

        GameObject target = Instantiate(targetPrefab, destinations[index].position, Quaternion.identity);
        target.transform.SetParent(destinations[index]);
    }
}

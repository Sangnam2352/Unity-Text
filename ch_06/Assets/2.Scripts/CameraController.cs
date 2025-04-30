using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = player.transform.position;
        transform.position = new Vector3(
            transform.position.x,
            PlayerPos.y,
            transform.position.z
            );
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;

    AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);

                
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collision 발생.");
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "apple")
        {
            Debug.Log("사과를 잡았다.");
            aud.PlayOneShot(appleSE);

        }
        else if(other.gameObject.tag == "bomb")
        {
            Debug.Log("폭탄을 잡았다.");
            aud.PlayOneShot(bombSE);
        }
        Destroy(other.gameObject);
    }

}

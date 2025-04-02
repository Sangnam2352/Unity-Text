using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController1 : MonoBehaviour
{
    float speedRatio = 0.0005f;
    float decreaseRate = 0.97f;
    float speed = 0f;
    float stopspeed = 0.04f;
    Vector2 startPos;
    Vector2 endPos;
    AudioSource audio;

    bool gameEnded = false;
    bool carStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameEnded) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        { 
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength * speedRatio;
            audio.Play();
            carStarted = true;
        }

            transform.Translate(speed, 0, 0);
        speed *= decreaseRate;

        if(carStarted && speed < stopspeed)
        {
            speed = 0f;
            gameEnded = true;
        }
    }
}

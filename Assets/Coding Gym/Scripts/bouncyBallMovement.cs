using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class bouncyBall : MonoBehaviour
{
    float ballSpeedx = 0.1f;
    float ballSpeedy = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move in a random x/y direction
        Vector3 pos = transform.position;

        pos.x += ballSpeedx;
        pos.y += ballSpeedy;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);
        
        //screen border collision detection
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            ballSpeedx = ballSpeedx * -1;
        }
        
        if (screenPos.y < 0|| screenPos.y > Screen.height)
        {
            ballSpeedy = ballSpeedy * -1;
        }

        transform.position = pos;

        //Up/down change ball size

        //L/R change ball speed
        
        Input.GetAxis("Horizontal");

        //spacebar reset ball to 0,0
       if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector2(0, 0);
            ballSpeedx = Random.Range(0.1f, 1f);
            ballSpeedy = Random.Range(0.1f, 1f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float initialSpeed = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // up/down to change size of ball
        Input.GetAxisRaw("Vertical");


        // L/R to change speed of ball
        Vector2 pos = transform.position;

       


        // space to reset ball position



    }
}

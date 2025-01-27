using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasPedal : MonoBehaviour
{
    //create the property of 'wheel' so that rotation can be modified
    public wheelController backWheel;
    public wheelController frontWheel;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keyboard G key interaction
        if (Input.GetKeyDown(KeyCode.G))
        {
            //click G to increase car speed (wheelRot)
            backWheel.wheelRot += 1.0f;
            frontWheel.wheelRot += 1.0f;
        }

    }
}

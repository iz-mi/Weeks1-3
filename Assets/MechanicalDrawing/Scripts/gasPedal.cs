using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasPedal : MonoBehaviour
{
    //create the property of 'wheel' so that rotation can be modified
    public wheelController backWheel;
    public wheelController frontWheel;

    //create an animation curve that affects the gas Pedal control
    public AnimationCurve gasPedalScale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //click the G key to increase car speed (wheelRot)
        if (Input.GetKeyDown(KeyCode.G))
        {
            backWheel.wheelRot += 1.0f;
            frontWheel.wheelRot += 1.0f;
        }

        //click the B key to decrease car speed (wheelRot)
        if (Input.GetKeyDown(KeyCode.B))
        {
            backWheel.wheelRot -= 1.0f;
            frontWheel.wheelRot -= 1.0f;
        }
    }
}

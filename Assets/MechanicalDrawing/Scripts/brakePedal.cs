using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brakePedal : MonoBehaviour
{
    //create the property of 'wheel' so that rotation can be modified
    public wheelController backWheel;
    public wheelController frontWheel;

    //create an animation curve that affects the gas Pedal control
    public AnimationCurve brakePedalScale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //click the B key to decrease car speed (wheelRot)
        if (Input.GetKeyDown(KeyCode.B))
        {
            backWheel.wheelRot -= 1.0f;
            frontWheel.wheelRot -= 1.0f;
        }
    }
}

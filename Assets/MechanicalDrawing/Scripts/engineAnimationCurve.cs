using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engineAnimationCurve : MonoBehaviour
{   
    //create an animation curve that affects the engine in the top right
    public AnimationCurve engineCurve;
    public wheelController rotSpeed;
    [Range(0, 1)]//editor-only tool to help visualize animation curve of object
    public float engineT;

    // Start is called before the first frame update
    void Start()
    {
        engineT = 0;
    }

    // Update is called once per frame
    void Update()
    {   
        //play animation curve of engine, scaling with how fast the car is moving
        engineT += Time.deltaTime * rotSpeed.wheelRot;

        //loop animation when driving forward
        if (engineT > 1)
        {
            engineT = 0;
        }
        
        //loop animation whend driving backward
        if (engineT < 0)
        {
            engineT = 1;
        }
        transform.localScale = Vector2.one * engineCurve.Evaluate(engineT);
    }
}
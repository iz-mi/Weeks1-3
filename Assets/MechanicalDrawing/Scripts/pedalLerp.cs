using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedalLerp : MonoBehaviour
{
    public wheelController rotSpeed;

    [Range(0, 1)]
    public float pedalT;
    public AnimationCurve pedalCurve;
    public Vector2 startpoint;
    public Vector2 endpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pedalT += Time.deltaTime * rotSpeed.wheelRot;
        //loop animation when driving forward
        if (pedalT > 1)
        {
            pedalT = 0;
        }
        //loop animation whend driving backward
        if (pedalT < 0)
        {
            pedalT = 1;
        }
        transform.position = Vector2.Lerp(startpoint, endpoint, pedalCurve.Evaluate(pedalT));
    }
}

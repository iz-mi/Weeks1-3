using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelController : MonoBehaviour
{
    //make the variable of wheel rotation public so gasPedal can access it
    public float wheelRot = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //default clockwise rotation speed of car wheels
        Vector3 currentRot = transform.eulerAngles;
        currentRot.z -= wheelRot;
        transform.eulerAngles = currentRot;
    }
}
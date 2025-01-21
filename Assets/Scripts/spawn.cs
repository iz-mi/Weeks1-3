using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{   
    //create prefab to instantiate
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create a new circle whenever left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, mouse, Quaternion.identity);

            //Instantiate(prefab,spriteRenderer.Random.ColorHSV);
        }

    }
}

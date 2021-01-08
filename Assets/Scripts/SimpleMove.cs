using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public float speed = 2f;

    // common types of variables use in unity

    /*
    bool isMoving;      // e.g. true, false
    int counter;        // e.g. 0, 1, 2
    float speed;        // e.g. 10.5f, 20f
    string objName;     // e.g. "hello"
    Vector3 direction;  // e.g. (1, 0, 0)
    GameObject npc;     
    Transform target;   
    */

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(speed);

        // demonstrating a function call with a parameter
        SayHi("Jonah");
    }

    // Update is called once per frame
    void Update()
    {
        // all different ways to move right 
        //transform.position = transform.position + new Vector3(0.2f, 0, 0);
        //transform.position += new Vector3(0.2f, 0, 0);
        //transform.position += Vector3.right * 0.2f;

        // getting input mapped to Horizontal access (set in Project Settings > Input)
        // "A" and left arrow return -1, "D" and right arrow return 1
        float hInput = Input.GetAxis("Horizontal");

        // translating from current pos to input * forward vector * speed * time passed between frames
        // to ensure consistent frame rate across devices
        transform.Translate(Vector3.right * speed * Time.deltaTime * hInput);

        // getting input mapped to Vertical access (set in Project Settings > Input)
        // "S" and down arrow return -1, "W" and up arrow return 1
        float vInput = Input.GetAxis("Vertical");

        // translating from current pos to input * forward vector * speed * time passed between frames
        // to ensure consistent frame rate across devices
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vInput);
    }

    // a function definition with a character
    void SayHi(string hiName)
    {
        Debug.Log("Hi, " + hiName);
    }


}

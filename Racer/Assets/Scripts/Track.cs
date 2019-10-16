using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour
{
    public float trackSpeed;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        // These will call 'increaseSpeed' function every 30 seconds which will increase the track speed by 0.5
        //InvokeRepeating("increaseSpeed",1.0f,30.0f);
    }

    // Update is called once per frame
    void Update()
    {
       offset = new Vector2(0, Time.time * trackSpeed);
       GetComponent<Renderer>().material.mainTextureOffset = offset;    
    }

    /** 
    void increaseSpeed(){
        trackSpeed = trackSpeed + 0.5f;
    }
    */
}

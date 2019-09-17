using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControl : MonoBehaviour
{
    Rigidbody rigidbody;
    public int speed;
    void Start()
    {
        rigidbody=this.GetComponent<Rigidbody>();
        speed=10;
    }

    // Update is called once per frame
    void Update()
    {
        Motion();
    }
    void Motion(){

        if(Input.GetKey(KeyCode.W)){
            rigidbody.velocity=new Vector3(-1*speed,0,0);

         } 
         if(Input.GetKey(KeyCode.S)){
             rigidbody.velocity=new Vector3(1*speed,0,0);
         
         }
         if(Input.GetKey(KeyCode.D)){
             rigidbody.velocity=new Vector3(0,0,1*speed);
         }
         if(Input.GetKey(KeyCode.A)){
             rigidbody.velocity=new Vector3(0,0,-1*speed);
         }
         
    }
}

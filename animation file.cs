using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
       public float speed=6;
      public float turnspeed=2;
    
 // Update is called once per frame
    void Update()
    {
        float strafe= Input. GetAxis ("Horizontal");
       float forward=Input.GetAxis("vertical");

      transform.Translate=(new vector3(strafe, 0 ,forward)* speed *Time.deltaTime);

     float turn = Input.GetAxis("Mouse X");

    transform.rotation *= Quaternion.Slerp(Quaternion .indentity,Quaternion.LookRotation(turn < 0; vector3.left : vector3.right), Mathf.Abs( turn ) *  turnSpeed * Time.deltaTime);
    }
}

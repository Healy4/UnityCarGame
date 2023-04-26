using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fow : MonoBehaviour
{
    //public Rigidbody RigidBody;
    public GameObject player; //Игрок
    //Transform target : Transform; //What to rotate around
    float distance = 5.0f; //How far away to orbit
    float xSpeed = 125.0f; //X sensitivity
    float ySpeed = 50.0f; //Y sensitivity

    private float x = 0.0f; //Angle of the y rotation?
    private float y = 0.0f; //Angle of the x rotation?

    //@script AddComponentMenu("Scripts/Mouse Orbit"); //Add to menu

    void Start() {   //Run this once at the start
        //Initialize the angles
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void LateUpdate() { //Every frame, do this as late as you can
        float pl = player.GetComponent<NewControls>().RigidBody.position.x;
        if (true) {//There's a target
            //Change the angles by the mouse movement
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            //Rotate the camera to those angles 
            //Quaternion rotation = Quaternion.Euler(y, x, 0f);
            //transform.rotation = rotation;

            //Move the camera to look at the target
            //Quaternion position = rotation * Vector3(0.0f, 0.0f, -distance) + target.position;
            //transform.position = position;
        }
    }
}

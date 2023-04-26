using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class NewControls : MonoBehaviour
{

    [SerializeField] float LaunchSpeed = 15000f;
    [SerializeField] float RotSpeed = 10f;

    private float moveInput;
    public Rigidbody RigidBody;

    enum State { Playing, Dead, NextLVL }
    State state = State.Playing;
    public float speed = 0f;

    //Параметры камеры
    public float camRot_x = 34.0f;
    public float camRot_y = 90f;
    public float camRot_z = 0f;
    
    public Camera cam;

    public AudioSource sound;
    public AudioClip accel;
    public AudioClip idle;
    public AudioClip brake;

    void Start()
    {     
        state = State.Playing;
        RigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        speed = RigidBody.velocity.magnitude;
        if (state == State.Playing)
        {
            Launch();
            Rotation(speed);
        }
    }
    void Rotation(float speed) //  вращение
    {
        float RotationSpeed = RotSpeed * Time.deltaTime;
        if (speed > 1) {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up * RotationSpeed );
                //cam.transform.Rotate(Vector3.up * RotationSpeed );
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.down * RotationSpeed);
                //cam.transform.Rotate(Vector3.down * RotationSpeed );
            }
            else {
                    //cam.transform.localEulerAngles = new Vector3(camRot_x, camRot_y, camRot_z);
                    //cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, Quaternion.Euler(camRot_x, camRot_y, camRot_z), Time.deltaTime);
                    //Debug.Log(cam.transform.rotation);
            }
        }
    
 
 
 
        }
 
   public void Launch() // Движение вперед
    {
 
        float LSpeed = LaunchSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            RigidBody.AddRelativeForce(Vector3.right * LSpeed);
            if (!sound.isPlaying) {
                sound.Stop();
                sound.PlayOneShot(accel, 0.5F);
            }
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            RigidBody.AddRelativeForce(Vector3.left * LSpeed);
            sound.Stop();
        }
        
    }
}
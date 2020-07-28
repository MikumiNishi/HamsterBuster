using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //const float Gravity = 9.81f;

    //public float gravityScale = 1.0f;
    public float VerticalSpeed = 1.0f;
    public float HorizontalSpeed = 1.0f;
    public Rigidbody Unity;


    // Start is called before the first frame update
    void Start()
    {
        Unity = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 vector = new Vector3();



        float z = Input.GetAxis("Horizontal") * HorizontalSpeed;
        float y = Input.GetAxis("Vertical") * VerticalSpeed;

        Unity.AddForce(0, 0, z);
        //Unity.AddTorque(0, y, 0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioPleyerMovment : MonoBehaviour
{
    public Rigidbody2D rBody;
    public GroundSensor sensor;
    public Vector3 newPosition = new Vector3(50, 5, 0);
    public float movmentSpeed = 5;
    public float jumpForce = 10;
    private float inputHorizontal;
    public bool jump = false;
    void Awake ()
    {
        rBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //teletransporta al monigote con variable newPosition
        //transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(1, 0,0) * movmentSpeed * Time.deltaTime;
        //transform.position += new Vector3(inputHorizontal, 0, 0) * movmentSpeed * Time.deltaTime;
       
        /*if(jump == true)
        {
            Debug.Log("estoy saltando illo");
        }
        else if(jump == false)
        {
            Debug.Log("estoy en el suelo illo");
        }
        else
        {
            Debug.Log("illoooooooooooo");
        }*/
        if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        rBody.velocity = new Vector2(inputHorizontal * movmentSpeed, rBody.velocity.y);
    }
}

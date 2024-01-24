using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rBody; 
    public GroundSensor sensor;
    public SpriteRenderer render;
    public Vector3 newPosition = new Vector3(50, 5, 0);
    public float jumpforce = 10;
    public float movementSpeed = 5;
    private float inputHorizontal;
    public Animator anim;

    public bool jump = false;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update

    void Start()
    {
        // Teletransporta al personaje a la posicion de la variable newPosition 
        // Transform.position = newPosition

        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(1, 0, 0) * movementSpeed * Time.deltaTime;
        //transform.position +- new Vector (Input Horizontal 1, 0, 0) * movementSpeed * Time.DeltaTime;
        
        

        /*if(jump == true)
        { 
            Debug.Log("Estoy saltando");
        }
         else if (jump == false)
        {
            Debug.Log("Estoy saltando");
        }
        else
        {
            Debug.Log("Estoy saltando");

        }*/
        if(Input.GetButtonDown("Jump") && sensor.isGrounded = true)
        {
            rBody.AddForce(new Vector2(0, 1) * jumpforce, ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
        }

        if(inputHorizontal < 0)
        {
            render.flipX = true;
            anim.SetBool("IsRunning", true);
        }
        else if(inputHorizontal > 0)
        {
            render.flipX = false;
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
       
    }
    void FixedUpdate()
    {
    rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }
}
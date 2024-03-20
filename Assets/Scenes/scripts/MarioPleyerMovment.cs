using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rBody; 

    public GroundSensor sensor;
    public SpriteRenderer render;
    public Animator anim;
    AudioSource source;

    public Vector3 newPosition = new Vector3(50, 5, 0);
    public float jumpforce = 5;

    public float movementSpeed = 5;
    private float inputHorizontal;
    public bool jump = false;

    public AudioClip jumpSound;

    public Transform bulletSpawn;
    public GameObject bulletPrefab;

    public bool canShoot = true;
    public float timer;
    public float rateOffFire = 1f;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        
        Jump();
        Movement();
        Shoot();
       
    }

    void FixedUpdate()
    {
    rBody.velocity = new Vector2(inputHorizontal * movementSpeed, rBody.velocity.y);
    }

    void Movement()
    {
        if(inputHorizontal < 0)
        {
            //render.flipX = true;
            transform.rotation = Quaternion.Euler(0, 100, 0);
            anim.SetBool("IsRunning", true);
        }
        else if(inputHorizontal > 0)
        {
            //render.flipX = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("IsRunning", true);
        }
        else
        {
            anim.SetBool("IsRunning", false);
        }
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
            
            if(sensor.isGrounded)
            {
                 rBody.AddForce(new Vector2(0, 1) * jumpforce, ForceMode2D.Impulse);
                 anim.SetBool("IsJumping", true);
                 source.PlayOneShot(jumpSound);
            }
            else if(sensor.isGrounded == true)
            {
                 anim.SetBool("IsJumping", true);
            }
           
        }

    }

    void Shoot()
    {
        if(!canShoot)
        {
            timer += Time.deltaTime;

            if(timer >= rateOffFire)
            {
                canShoot = true;
                timer = 0;
            }
        }

        if(Input.getKeyDown(KeyCode.F) && canShoot);
        {
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

            canShoot = false;
        }
    }
}
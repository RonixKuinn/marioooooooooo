using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour

{
    public bool isGrounded;
    public Animator anim;
    PlayerMovement MarioPleyerMovement;

    void Awake()
    {
        anim = GetComponentInParent<Animator>();
        MarioPleyerMovement = GetComponentInParent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Goombas")
        {
            MarioPleyerMovement.rBody.AddForce(Vector2.up * MarioPleyerMovement.jumpforce, ForceMode2D.Impulse);
            anim.SetBool("IsJumping", true);
            //Destroy(collider.gameObject);
            Enemy goomba = collider.gameObject.GetComponent<Enemy>();

            goomba.GoombaDeath();
        }

        isGrounded = true;
        anim.SetBool("IsJumping", false);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        isGrounded = false;
    }

    void Start()
    {

    }
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public Animator anim;
    private BoxCollider2D boxCollider2D;

    private AudioSource source;
    public AudioClip coinSound;

    void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.ParaChoques.tag == "Player")
        {
            Destroy(collision.ParaChoques);
        }
    }
    */
    
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("IsDancing", true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CoinDesapeard()
    {
        source.PlayOneShot(coinSound);
        boxCollider2D.enabled = false;
        Destroy(gameObject, 0.5f);
    }
}

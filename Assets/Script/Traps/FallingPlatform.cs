using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            anim.SetBool("fall", true);
            Invoke("DropPlatform", 0.5f);
            Destroy(gameObject, 1.8f);
        }
       /* else 
        {
            anim.SetBool("fall", false);
        }
       */
    }

    private void DropPlatform()
    {
        rb.isKinematic = false;
    }
}

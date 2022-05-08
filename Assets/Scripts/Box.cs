using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    
     public float jumpForce;
     public bool isUp;
     public Animator anim;
     public int health = 5;
     public GameObject effect;

    
    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Instantiate(
                effect, transform.parent.position,
                transform.parent.rotation
            );
            Destroy(transform.parent.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(isUp)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(
                new Vector2(0f, jumpForce),
                ForceMode2D.Impulse
                );
            }
            else 
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(
                new Vector2(0f, -jumpForce),
                ForceMode2D.Impulse
                );
            }
            health--;
            anim.SetTrigger("hit");
        }

    }

}

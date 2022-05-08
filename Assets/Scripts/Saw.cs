using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    
    public float speed;
    public float moveTime;
    private bool dirRight = true;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        if(dirRight)
        {
            // if true the saw goes to the right
            transform.Translate(
                Vector2.right * speed * Time.deltaTime
            );
        } 
        else
        {   
            // if false the saw goes to the left
            transform.Translate(
                Vector2.left * speed * Time.deltaTime
            );
        }

        timer += Time.deltaTime;
        if(timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }
    }

}

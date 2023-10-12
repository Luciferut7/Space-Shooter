using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Speed = .5f;

    private void Update()
    {
        transform.position += -transform.right * Time.deltaTime * Speed;
    }

   /* void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the object you want to destroy.
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            // Destroy the other object (the one that collided with this object).
            Destroy(collision.gameObject);
        }
    }
}

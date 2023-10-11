using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    public float speed = 5.0f;
    private Transform spawnPoint;

    void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint").transform;
        transform.position = spawnPoint.position;
    }

    void Update()
    {
        // Move the obstacle downward
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Check if the obstacle is below the screen
        if (transform.position.y < -10f) // You may adjust this value as needed
        {
            Destroy(gameObject); // Destroy the obstacle when it's off-screen
        }
       /* SomeClass obj = null;
        // Attempting to access a property or method on obj will result in the error.
        obj.SomePropertyOrMethod();*/

    }
     private void OnCollisionEnter2D(Collision2D collision)
 {
     // Check if the collision is with the object you want to destroy.
     if (collision.gameObject.CompareTag("Destroyable"))
     {
         // Destroy the other object (the one that collided with this object).
         Destroy(collision.gameObject);
     }
 }
}

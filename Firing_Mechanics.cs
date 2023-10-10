using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing_Mechanism : MonoBehaviour
{
    public GameObject projectilePrefab; // Reference to your projectile prefab
    public Transform firePoint; // The point from which projectiles are fired
    public float fireForce = 10f; // The force applied to the projectile

    private float fireCooldown = 0.5f; // Cooldown time in seconds
    private float nextFireTime = 0f;

    void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.Space)) // Change KeyCode to the desired input key
         {
             ShootProjectile();
         }*/
        if (Time.time > nextFireTime && Input.GetKeyDown(KeyCode.Space))
        {

            ShootProjectile();


            nextFireTime = Time.time + fireCooldown;
        }
    }

    void ShootProjectile()
    {
        // Instantiate the projectile
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Access the rigidbody of the projectile (assuming you have one attached)
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();

        // Apply force to the projectile to make it move
        if (rb != null)
        {
            rb.velocity = transform.up * fireForce; // Fire in the direction of the spaceship's forward (up in local space)
        }
    }
}

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

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }

}

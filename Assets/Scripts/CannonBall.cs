using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private float speed = 5.0f;
    //RigidBody
    Rigidbody2D rb;
    //Audio
    private AudioSource damage;

    void Start()
    {
        //Get Audio
        damage = GetComponent<AudioSource>();
        //Get RigidBody
        rb = GetComponent<Rigidbody2D>();
        //Apply velocity
        rb.velocity = transform.up * speed;
    }
}

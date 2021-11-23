using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rb;
    private AudioSource damage;
    void Start()
    {
        damage = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
}

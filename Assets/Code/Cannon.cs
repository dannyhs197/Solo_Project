using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timebetween;
    public float starttimebetween;
    private AudioSource cannon;
    void Start()
    {
        timebetween = starttimebetween;
        cannon = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(timebetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timebetween = starttimebetween;
            cannon.Play();
        }
        else
        {
            timebetween -= Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firepoint;
    //GameObject
    public GameObject bullet;
    //Fire Times
    private float timebetween;
    private float starttimebetween = 5;
    //Audio
    private AudioSource cannon;

    void Start()
    {
        //Set Fire Time
        timebetween = starttimebetween;
        //Get Audio
        cannon = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(timebetween <= 0)
        {
            //Create CannonBall
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

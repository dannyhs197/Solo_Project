using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timebetween;
    public float starttimebetween;
    void Start()
    {
        timebetween = starttimebetween;
    }

    void Update()
    {
        if(timebetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timebetween = starttimebetween;
        }
        else
        {
            timebetween -= Time.deltaTime;
        }
    }
}

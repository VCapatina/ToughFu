﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public Rigidbody2D rb;



    private void FixedUpdate()
    {
        rb.velocity = transform.right * bulletSpeed;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        Destroy(gameObject);
    }




}

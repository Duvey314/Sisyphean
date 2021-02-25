﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PathMovement : MonoBehaviour
{
    public float length, startposx, startposy, startrot, startpos;
    public GameObject cam;
    public float distancey;
    public float speed = 0.1f;
    public float tempx;

    // Start is called before the first frame update
    void Start()
    {
        startposx = transform.position.x;
        startposy = transform.position.y;
        startrot = transform.rotation.z;
        length = (float) Math.Cos(15.0) * (GetComponent<SpriteRenderer>().bounds.size.x);
    }

    // Update is called once per frame
    void Update()
    {
        tempx = (transform.position.x);
        //float tempy = (cam.transform.position.y);

        transform.position = new Vector2(startposx + cam.transform.position.x, startposy + cam.transform.position.y);

        // Vector3 A = Quaternion.Euler(0,0,15) * Vector3.left;
 
        // transform.position = new Vector2 (startposx + A.x, startposy + A.y);

        //if (tempx > startposx + length) startposx += length;
        //if (tempx < startposx - length) startposx += length;
    }
}
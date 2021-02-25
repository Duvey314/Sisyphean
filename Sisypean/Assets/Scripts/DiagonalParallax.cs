using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalParallax : MonoBehaviour
{
    private float length, startposx, startposy, startrot;
    public GameObject cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startposx = transform.position.x;
        startposy = transform.position.y;
        startrot = transform.rotation.z;
        float length = (float) Math.Cos(15.0) * (GetComponent<SpriteRenderer>().bounds.size.x);
    }

    // Update is called once per frame
    void Update()
    {
        float tempx = (cam.transform.position.x * (1 - parallaxEffect));
        float tempy = (cam.transform.position.y * (1 - parallaxEffect));
        float distancex = (float) ((Math.Cos(15.0) * cam.transform.position.x) * parallaxEffect);
        float distancey = (float) ((Math.Sin(15.0) * cam.transform.position.y) * parallaxEffect);
 
        transform.position = new Vector3(startposx + distancex, startposy + distancey, transform.position.z);

        if (tempx > startposx + length) startposx += length;
        else if (tempx < startposx - length) startposx -= length;
    }
}

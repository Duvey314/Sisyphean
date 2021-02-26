using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PathMovement : MonoBehaviour
{
    public float length, startposx, startposy, startrot, startpos;
    public GameObject cam;
    public float distancey;
    public float distancex;
    public float speed = 0.1f;
    public float tempx;
    public Vector3 A;
    private Vector2 temppos;
    private Vector3 campos;


    // Start is called before the first frame update
    void Start()
    {
        startposx = transform.position.x;
        startposy = transform.position.y;
        startrot = transform.rotation.z;
        //length = (GetComponent<SpriteRenderer>().bounds.size.x);
        length =  19.81502f;

    }

    // Update is called once per frame
    void Update()
    {
        tempx = (transform.position.x);
        float tempy = (transform.position.y);
        campos = cam.transform.position;
        //distancex = startposx - tempx;
        distancey = campos.y - tempy;
        distancex = campos.x - tempx;
        A = Quaternion.Euler(0,0,15) * Vector3.left;
        
        // if (speed > 1){
        //     transform.position = new Vector2((startposx + cam.transform.position.x), (startposy + cam.transform.position.y)) + new Vector2 ((transform.position.x + A.x), (transform.position.y + A.y));
        // }

        
        transform.position = new Vector2 ((transform.position.x + A.x), (transform.position.y + A.y));

        temppos = transform.position;

        //if (tempx > startposx + length) startposx += length;
        if (distancex > ((float) Math.Cos(0.261799) * length)){
            temppos.x += ((float) Math.Cos(0.261799) * length) *2;
            temppos.y += ((float) Math.Sin(0.261799) * length) *2;
            transform.position = temppos;
            startposx = temppos.x;
            startposy = temppos.y;
        }
    }
}

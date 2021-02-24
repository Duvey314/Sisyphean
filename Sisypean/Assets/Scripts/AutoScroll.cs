using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    // Start is called before the first frame update
     
    public float speed; 

    
    void Start()
    {
        InvokeRepeating("SlowDown", 1f, 0.5f);  //1s delay, repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed / 100;
        if (Input.GetKeyDown("space"))
        {
            if (speed < 10){
                speed += 1;
            }
           
        }

        var cameraPosition = Camera.main.gameObject.transform.position;
        cameraPosition.x += step;
        Camera.main.gameObject.transform.position = cameraPosition;
    }
    void SlowDown(){
        if (speed > 1){
            speed = (speed * 0.9f);
        }
    }
}

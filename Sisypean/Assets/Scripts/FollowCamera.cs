using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public float xOffset;
    public float yOffset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cam.transform.position + new Vector3(xOffset, yOffset, 10f);
    }
}

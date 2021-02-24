using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoulder : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boulder;
    public float rotationSpeed;
    public float speed2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed2 = boulder.GetComponent<AutoScroll>().speed;
        transform.Rotate(Vector3.back, (rotationSpeed * Time.deltaTime * speed2 * 2));
    }
}

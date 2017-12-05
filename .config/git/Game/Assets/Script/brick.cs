using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    public int speed;

    private Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
       speed = 3;

        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveBrick();
    }

    void moveBrick()
    {
        transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * speed), transform.position.z);
        
    }
}


/*
bool gameStarted = false;
// Use this for initialization
void Start () {

}

// Update is called once per frame
void Update () {
    if (Input.GetMouseButtonDown(0) && !gameStarted)
    {
        gameStarted = true;
        float moveSpeed = 7;

        transform.position = new Vector3(transform.position.x, transform.position.y - moveSpeed, transform.position.z);
    }
}
}
*/

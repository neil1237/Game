using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Rigidbody2D rigibod;
    public float Forceball;

    void Start()
    {

    }
    void Update()
    {
        rigibod.AddForce(new Vector2(Forceball, Forceball));
    }
}
    // Use this for initialization
    /*
    private Vector3 paddleToBallVector; 
    public Paddle paddle;
    Vector3 ballPaddleDiff;

    bool hasStarted = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {

        if (!hasStarted)//if false
        {
            if (Input.GetMouseButtonDown(0))
            {

                print("Left CLick");
                hasStarted = true;

               


            }/*
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
*/



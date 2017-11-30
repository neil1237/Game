using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle25 : MonoBehaviour
{
    /*
    // Use this for initialization
    float key = 0.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (true){
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (key <= 4)
                {
                    continue;
                }
                key++;
            }
            else
            {
                if (key >= -4)
                {
                    continue;
                }
                key--;
            }
        }
        


        /*
         * Calculating the new Mouse position in game units since pixel units are returned
         * screen width of 800 pixels is equivalent to 16 game units
         * Since there is still an offset difference between the mouse and the paddle
         * The offset was noticed to be on the negative side and that is why we need to reduce
         * - 8 game units.
        

        Vector3 newPaddlePos = new Vector3(0, gameObject.transform.position.y,
                                            gameObject.transform.position.z);

        // we needed to create a new variable for the new paddle position since we cannot change
        // one coordinate (e.g. x coordinate) on its own

        newPaddlePos.y = Mathf.Clamp(key, -4f, 4f);

        gameObject.transform.position = newPaddlePos;
        */
    }

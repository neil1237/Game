using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(Input.mousePosition.y);

        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 16) - 8;
        /*
         * Calculating the new Mouse position in game units since pixel units are returned
         * screen width of 800 pixels is equivalent to 16 game units
         * Since there is still an offset difference between the mouse and the paddle
         * The offset was noticed to be on the negative side and that is why we need to reduce
         * - 8 game units.
        */

        Vector3 newPaddlePos = new Vector3(mousePosInUnits, gameObject.transform.position.x,
                                            gameObject.transform.position.z);

        // we needed to create a new variable for the new paddle position since we cannot change
        // one coordinate (e.g. x coordinate) on its own

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -7.35f, 7.35f);

        gameObject.transform.position = newPaddlePos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public int Speed = 12;
    void Update()
    {
        Vector3 movement = new Vector3(0, Input.GetAxis("Vertical") * Speed, 0);
        this.transform.Translate(movement * Time.deltaTime);
    }
}

using System.Collections;
using UnityEngine;

public class newball : MonoBehaviour {
    public Rigidbody2D rb;
    public float Forceball;

    void Start()
    {
        rb.AddForce(new Vector2(Forceball, Forceball));
    }
    void Update()
    {
        
    }
}

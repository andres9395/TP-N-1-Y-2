﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 50f;
    public float jumpPower = 150f;

    public bool grounded;

    private Rigidbody2D rb2d;
	
	void Start () {

        rb2d = gameObject.GetComponent<Rigidbody2D>();
	
	}
	
	
	void Update ()
    {

    }
    void FixedUpdated()
    {
        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce((Vector2.right * speed) * h);
    }
}

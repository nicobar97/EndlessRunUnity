using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    
	public float speed = 0f;
	private Rigidbody2D myRB;

    void Start() {
        myRB = GetComponent<Rigidbody2D>();
    }

    void Update() {
        myRB.velocity = new Vector2(speed, 0);
    }
}
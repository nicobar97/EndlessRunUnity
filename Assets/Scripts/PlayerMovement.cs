using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
	public float jumpForce = 10f;
	public float forwardForce = 0f;

	private Rigidbody2D myRB;
	private bool canJump;

    void Start() {
        myRB = GetComponent<Rigidbody2D>();
    }

	void OnCollisionEnter2D(Collision2D other) {
    	canJump = true;
    }
	
    public void Jump(){
    	if (canJump){
    		canJump = false;
    		if (transform.position.x < -5) {
    			forwardForce = 0.5f;
    		} else {
    			forwardForce = 0f;
    		}
    		myRB.velocity = new Vector2 (forwardForce, jumpForce);
    	}
    }

    
}
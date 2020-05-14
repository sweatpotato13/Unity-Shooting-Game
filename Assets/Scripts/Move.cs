using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Vector2 speed = new Vector2(5, 5);
	public Vector2 direction = new Vector2(-1, 0);

	private Vector2 movement;
	private Rigidbody2D myRigid;

	void Start () {
		myRigid = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
	}

	void FixedUpdate(){
		myRigid.velocity = movement;
	}

}

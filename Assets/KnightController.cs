using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KnightController : MonoBehaviour {

	float speed = 7;
	float rotationSpeed = 70;
	float rotation = 0f;
	float gravity = 9.8f;
	Vector3 moveDirection = Vector3.zero;
	CharacterController controller;
	Animator animator;

	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<CharacterController> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement();
	}

	void Movement()
	{
		if (controller.isGrounded) {
			if (Input.GetKey(KeyCode.W)) 
			{
				animator.SetInteger ("condition", 1);
				moveDirection = new Vector3 (0, 0, 1);
				moveDirection *= speed;
				moveDirection = transform.TransformDirection (moveDirection);
			}
			if (Input.GetKeyUp(KeyCode.W))
			{
				animator.SetInteger ("condition", 0);
				moveDirection = new Vector3 (0, 0, 0);
			}
			rotation += Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
			transform.eulerAngles = new Vector3 (0, rotation, 0);
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}
}

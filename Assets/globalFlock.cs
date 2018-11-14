using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour {//pls ignore comments...


	public GameObject footPrefab;

	public static int quarterFormation = 4;
	static int fullFormation = 6;
	public static GameObject[] allFoot = new GameObject[fullFormation];

    //public KnightController KnightController { get => _knightController; set => _knightController = value; }

    // Use this for initialization
    void Start () {

		// controller = GetComponent<CharacterController> ();
		// animator = GetComponent<Animator> ();

		for (int i = 0; i < fullFormation; i++) {
			Vector3 formation = new Vector3(Random.Range(footPrefab.transform.position.x-quarterFormation,footPrefab.transform.position.x+quarterFormation),
											footPrefab.transform.position.y,
											Random.Range(footPrefab.transform.position.z-quarterFormation,footPrefab.transform.position.x+quarterFormation));
			allFoot [i] = (GameObject)Instantiate (footPrefab, formation, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	// void Update () {
	// 	foreach (var item in allFoot)
	// 	{
	// 		_knightController.Invoke("Movement", 0.2f);
	// 	}
	// 	//Movement();
	// }

	// void Movement() {
	// 	if (controller.isGrounded) {
	// 		if (Input.GetKey(KeyCode.W)) 
	// 		{
	// 			animator.SetInteger ("condition", 1);
	// 			moveDirection = new Vector3 (0, 0, 1);
	// 			moveDirection *= speed;
	// 			moveDirection = transform.TransformDirection (moveDirection);
	// 		}
	// 		if (Input.GetKeyUp(KeyCode.W))
	// 		{
	// 			animator.SetInteger ("condition", 0);
	// 			moveDirection = new Vector3 (0, 0, 0);
	// 		}
	// 		rotation += Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
	// 		transform.eulerAngles = new Vector3 (0, rotation, 0);
	// 	}
	// 	moveDirection.y -= gravity * Time.deltaTime;
	// 	controller.Move (moveDirection * Time.deltaTime);
	// }
}

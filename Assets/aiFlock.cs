using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiFlock : MonoBehaviour {//trying out stuff, not implemented
	//ne e implementirano...
	public GameObject aiPrefab;
	public static int quarterFormation = 4;
	static int fullFormation = 9;
	public static GameObject[] allAi = new GameObject[fullFormation];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < fullFormation; i++) {
			Vector3 formation = new Vector3(Random.Range(aiPrefab.transform.position.x-quarterFormation,aiPrefab.transform.position.x+quarterFormation),
				aiPrefab.transform.position.y,
				Random.Range(aiPrefab.transform.position.z-quarterFormation,aiPrefab.transform.position.x+quarterFormation));
			allAi [i] = (GameObject)Instantiate (aiPrefab, formation, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

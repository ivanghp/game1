using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalFlock : MonoBehaviour {


	public GameObject footPrefab;

	public static int quarterFormation = 4;
	static int fullFormation = 6;
	public static GameObject[] allFoot = new GameObject[fullFormation];

    
    void Start () {


		for (int i = 0; i < fullFormation; i++) {
			Vector3 formation = new Vector3(Random.Range(footPrefab.transform.position.x-quarterFormation,footPrefab.transform.position.x+quarterFormation),
											footPrefab.transform.position.y,
											Random.Range(footPrefab.transform.position.z-quarterFormation,footPrefab.transform.position.x+quarterFormation));
			allFoot [i] = (GameObject)Instantiate (footPrefab, formation, Quaternion.identity);
		}
	}
	
}

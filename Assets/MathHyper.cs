using UnityEngine;
using System.Collections;

public class MathHyper : MonoBehaviour {



	public static float sqrRayon = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static float Facteur (GameObject objet) {
		
		float posX = objet.transform.position.x;
		float posZ = objet.transform.position.z;
		float sqrDistance = posX * posX + posZ * posZ;
		float distance = Mathf.Sqrt(1 - sqrDistance / sqrRayon);
		
		//Debug.Log(distance, gameObject);

		return distance;

	}
}

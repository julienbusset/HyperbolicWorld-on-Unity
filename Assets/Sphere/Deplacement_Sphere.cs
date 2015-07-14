using UnityEngine;
using System.Collections;

public class Deplacement_Sphere : MonoBehaviour {

	public static float speed = 10.0f;
	public static float rotationSpeed = 100.0f;
	public static Vector3 vecteur111 = new Vector3(1,1,1);



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) {
			Deplacement ();
		}

	}

	void Deplacement () {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		float ancienFacteur = MathHyper.Facteur (GameObject.Find ("Sphere"));	//sert pour baisser a la bonne hauteur
		float nouveauFacteur;

		//multiplication par le facteur hyperbolique
		translation = translation * MathHyper.Facteur (GameObject.Find("Sphere"));

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
		//sert pour baisser a la bonne hauteur
		nouveauFacteur = MathHyper.Facteur (GameObject.Find ("Sphere"));

		//echelle
		transform.localScale = vecteur111 * MathHyper.Facteur (GameObject.Find("Sphere"));
		Debug.Log (MathHyper.Facteur (GameObject.Find ("Sphere")));
		
		//puis baisse de la moitie de la nouvelle taille
		transform.Translate(0, (nouveauFacteur - ancienFacteur) / 2, 0);

	}

}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int Force = 10;

	public GameObject thruster1;
	public GameObject thruster2;
	public GameObject thruster3;
	public GameObject thruster4;


	Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 force = new Vector3 (0, 0, 0);
		Vector3 pos = new Vector3 (0, 0, 0);
		if (Input.GetKeyDown (KeyCode.W)) {
			force = new Vector3 (0, -Force, 0);
			pos = thruster1.transform.position;
		}

		rb.AddForceAtPosition (force, pos);
		Debug.Log ("Applying force : " + force.ToString () + " at : " + pos.ToString ());
	}
}

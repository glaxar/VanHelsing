using UnityEngine;
using System.Collections;

public class Crab : MonoBehaviour {

	public float speed = 5f;
	private Rigidbody body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		var hor = Input.GetAxis ("Horizontal");
		var vert = Input.GetAxis ("Vertical");
		body.velocity = new Vector3 (speed * hor, body.velocity.y);
	}
}

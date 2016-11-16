using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody myRigidBody;
	public float speed;
	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");
		Vector3 force = new Vector3 (moveHorizontal, 0, moveVertical);
		myRigidBody.AddForce (force*speed);

	}
}

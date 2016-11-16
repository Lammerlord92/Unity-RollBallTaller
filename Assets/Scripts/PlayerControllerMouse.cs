using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControllerMouse : MonoBehaviour {
	//Movimiento del jugador
	public float speed;
	private Rigidbody myRigidBody;
	private Vector3 nextPosition;
	//Objetos coleccionables
	public Text text;
	private float collectionableObjects;

	void Start () {
		//Movimiento del jugador
		myRigidBody = GetComponent<Rigidbody> ();
		//Objetos coleccionables
		collectionableObjects = 0f;
		text.text="Collectionable objects: 0";
	}
	//Movimiento del jugador
	void Update(){
		//if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				//myRigidBody.velocity = Vector3.zero;
				nextPosition = hit.point;
			}
		//}
	}
	void FixedUpdate () {
		Vector3 direction =nextPosition-transform.position;
		direction.Normalize ();
		myRigidBody.AddForce (direction*speed);

	}
	//Objetos coleccionables
	void OnCollisionEnter(Collision _other){
		if (_other.transform.tag == "Collectionable") {
			collectionableObjects += 1;
			text.text="Collectionable objects: "+collectionableObjects;
			Destroy (_other.gameObject);
		}
	}
}

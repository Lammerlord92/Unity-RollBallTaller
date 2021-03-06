﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	//Movimiento del jugador
	public float speed;
	private Rigidbody myRigidBody;
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
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");
		Vector3 force = new Vector3 (moveHorizontal, 0, moveVertical);
		myRigidBody.AddForce (force*speed);

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

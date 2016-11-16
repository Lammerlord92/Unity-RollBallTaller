using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	private Vector3 offset;
	public Transform playerTransform;
		
	void Start(){
		offset =transform.position-playerTransform.position ;
	}
	// Update is called once per frame
	void Update () {
		transform.position = playerTransform.position+offset;
		//transform.LookAt (playerTransform);
	}
}

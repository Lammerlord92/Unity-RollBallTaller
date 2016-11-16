using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {
	public float force=5f;
	void OnTriggerStay(Collider _other){
		Vector3 forceUp=Vector3.up * force;
		if (_other.gameObject.tag == "Player") {
			_other.attachedRigidbody.velocity=forceUp;
		}
	}
}

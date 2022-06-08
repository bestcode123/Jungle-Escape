using System.Collections;
using System;
using UnityEngine;

public class Respawn : MonoBehaviour {
	void OnCollisonEnter(Collision collsion) {
		if(collision.gameObject.tag == "destroyblock") {
			Destroy(this.gameObject);
		} else {
			Debug.Log("Object Collsion: ", collsion);
		}
	}
	
	void Start() {}
	void Update() {}
}
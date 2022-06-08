using System.Collections;
using System;
using UnityEngine;

public class GameLife : MonoBehaviour {
	void OnCollisonEnter(Collision collsion) {
		// Death Object Collision
		if(collision.gameObject.tag == "destroyblock") {
			Destroy(this.gameObject);
		} else {
			Debug.Log("Object Collsion: ", collsion);
		}
	}
	
	void Start() {}
	void Update() {}
}
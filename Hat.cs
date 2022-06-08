using System.Collections;
using System;
using UnityEngine;

public class Hat : MonoBehaviour {
	public GameObject character;
	public Vector3 offset;
	void Start() {
		
	}
	void Update() {
		this.transform.position = character.transform.position + offset;
	}
}
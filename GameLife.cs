using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameLife : MonoBehaviour {
	private int levelIndexVar = SceneManagement.Scene.buildIndex;
	int LoadLevel(int levelIndex, string levelName) {
		if(levelIndex != null) {
			SceneManagement.SceneManager.loadLevelAsync(levelIndex);
			return 0;
		} else if(levelName != null) {
			SceneManagement.SceneManager.loadLevelAsync(LevelIndex);
			return 0;
		} else if(levelIndex && levelName) {
			Debug.Log("Error Use Case: 2 Full Arguements!");
			return 2;
		} else {
			Debug.Log("Error Use Case: No Arguements Given!");
			return 3;
		}
	}
	void OnCollisonEnter(Collision collsion) {
		// Death Object Collision
		if(collision.gameObject.tag == "destroyblock") {
			Destroy(this.gameObject);
		} else {
			Debug.Log("Object Collsion: ", collsion);
		}
		if(collision.gameObject.tag == "endblock") {
			LoadLevel(levelIndexVar + 1, null);
		}
	}
	
	void Start() {}
	void Update() {}
}
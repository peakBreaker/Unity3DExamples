using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void StartGame(int sceneNum) {
        Debug.Log("Starting Game!");
        SceneManager.LoadScene(sceneNum);
    }

    public void loadNextLevel() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene + 1);
    }

	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision occured!");
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

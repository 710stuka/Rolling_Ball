using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {
	
	private SceneManager SceanManager;
	private Button gameEnd;

	private void Start(){
		gameEnd = GameObject.Find ("GameEnd").GetComponent<Button> ();
		gameEnd.onClick.AddListener (onClickTriggered);
		//stuka
	}

	private void onClickTriggered(){
		Application.Quit ();
	}
}
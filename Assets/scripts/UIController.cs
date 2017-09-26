using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public Text GameClearLabel;
	public Text GameOverLabel;
	public Button Retry;
	public Button GameEnd;

	private void Start () {
		GameClearLabel.gameObject.SetActive (false);
		GameOverLabel.gameObject.SetActive (false);
		Retry.gameObject.SetActive (false);
		GameEnd.gameObject.SetActive (false);
	}
		
	public void ShowGameClearLabel () {
		GameClearLabel.gameObject.SetActive (true);
		GameEnd.gameObject.SetActive (true);
	}

	public void ShowGameOverLabel (){
		GameOverLabel.gameObject.SetActive (true);
		Retry.gameObject.SetActive (true);
	}
}

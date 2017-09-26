using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
	public UIController UIController;

	private void OnTriggerEnter(Collider hit)
	{
		if (hit.CompareTag ("Player")) {
			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;

			UIController.ShowGameOverLabel();
		}
	}
}

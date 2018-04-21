using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	// **Improvement** need to check if other objects trigger the end goal
	void OnTriggerEnter() {

		gameManager.CompleteLevel ();
	}

}

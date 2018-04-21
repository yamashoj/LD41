using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;

	// Use this for initialization
	void Start () {

	}

	public void EndGame(){

		if(gameHasEnded == false) {

			gameHasEnded = true;
			Debug.Log ("GAME OVER");

			//restart game
			Invoke("Restart", restartDelay);
		}
			
	}

	void Restart() {

		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex);

	}

	public void CompleteLevel() {

		completeLevelUI.SetActive (true);

	}
		
}

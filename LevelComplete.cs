using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel() {

		// final scene will be game completetion screen, perform check of buildindex against this
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex + 1);

	}

}

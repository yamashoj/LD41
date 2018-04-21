using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	public GameManager gameManager;

	void OnCollisionEnter(Collision collisionInfo){

		// Reset level, addforce, etc
		if (collisionInfo.collider.tag == "Obstacle") {

			movement.enabled = false;

			FindObjectOfType<AudioManager> ().Play ("Hit");

			FindObjectOfType<GameManager> ().EndGame ();


			// **Improvement** should be garbage collecting
			//Destroy (gameObject);
		
		}

	}

}

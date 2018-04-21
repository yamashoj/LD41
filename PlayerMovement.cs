using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Reference the RigidBody component quickly
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	// Update is called once per frame
	// Use FixedUpdate for physic functions
	void FixedUpdate () {

		//add force consistantly on the Z-Axis
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);		
	

		// Slight delay ~ needs improvement
		if (Input.GetKey("d")) {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		} else if(Input.GetKey("a")){

			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}
	
		if(rb.position.y < -3f){

			FindObjectOfType<GameManager> ().EndGame ();

		}

	}
		
}

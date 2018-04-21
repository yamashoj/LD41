using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;

	// Update is called once per frame
	void Update () {

		//score text by distance
		scoreText.text = player.position.z.ToString("0");
		//score text by time
		//scoreText.text = Time.time.ToString("F1");

	}
}

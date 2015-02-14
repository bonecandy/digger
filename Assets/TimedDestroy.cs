using UnityEngine;
using System.Collections;

public class TimedDestroy : MonoBehaviour {

	public float interval = 0.1f;
	float timeLeft = 0.1f;
	
	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		Destroy(gameObject); // we can change this later so it doesn't break on every block.
	} 
		// Update is called once per frame
	void Update () {
		// time to spawn the next one?
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0.0f && gameObject.name != "icon_fuel") {
			Destroy (this.gameObject);
			// reset time
			timeLeft = interval;
		}
	}
}

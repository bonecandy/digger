using UnityEngine;
using System.Collections;


public class melee : MonoBehaviour {
	void Awake() {
		if (gameObject.name != "icon_fuel") { // LOL. 'solution' to prevent destroying the original.
			Destroy (this.gameObject, 0.1f); // dies roughly halfway through a block.
		}
	}
	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		Destroy(gameObject); // we can change this later so it doesn't break on every block.
	} 
}
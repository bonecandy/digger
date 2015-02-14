using UnityEngine;
using System.Collections;

public class CashMoney : MonoBehaviour {

	// Use this for initialization

		void OnTriggerEnter2D(Collider2D collisionObject)
		{
		if (collisionObject.name == "badgerman_0") {	
						Destroy (gameObject); // we can change this later so it doesn't break on every block.
		 				PowerupManager.p1power += 1;
				}
		if (collisionObject.name == "icon_bug") {	
			Destroy (gameObject); // we can change this later so it doesn't break on every block.
			PowerupManager2.p2power += 1;
		}
}
	}


using UnityEngine;
using System.Collections;

public class bulletdestroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		Destroy(gameObject); // we can change this later so it doesn't break on every block.
	} 
}
using UnityEngine;
using System.Collections;

public class bulletscript : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		if (collisionObject.gameObject.tag == "breakable")	
		    {
			// bye bye destructible game object
			Destroy(gameObject);
		}
	} 
}
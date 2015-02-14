using UnityEngine;
using System.Collections;

public class dirtbreak : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collisionObject)
	{
		if (collisionObject.gameObject.tag == "dirt")
		{
			// bye bye destructible game object
			Destroy(collisionObject.gameObject);
		}
	} 
}

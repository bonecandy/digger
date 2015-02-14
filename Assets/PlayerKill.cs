using UnityEngine;
using System.Collections;

public class PlayerKill : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Ouchy")
		{
			Destroy(this.gameObject);
		}
	}
}
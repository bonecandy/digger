using UnityEngine;
using System.Collections;

public class P2Longfire : MonoBehaviour {
	
	public Rigidbody2D bullet;
	public float speed = 10f;
	
	
	void Firebullet2 () {
		Rigidbody2D bulletClone = (Rigidbody2D) Instantiate(bullet, transform.position, transform.rotation);
		bulletClone.velocity = transform.up * speed;
		
	}
	
	// Calls the fire method when holding down ctrl or mouse
	void Update () {
		
		if (TurnManager.whoseturn != 2) {
			return;
		}
		if (ScoreManager.score < 2) {
			return;
		}
		
		if (Input.GetButtonDown ("Fire2")) {
			Firebullet2 ();
			ScoreManager.score -= 2;
			
		}
	}
	
}
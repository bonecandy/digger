using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

		public Rigidbody2D bullet;
		public float speed = 10f;

		
		void Firebullet () {
		Rigidbody2D bulletClone = (Rigidbody2D) Instantiate(bullet, transform.position, transform.rotation);
			bulletClone.velocity = transform.up * speed;
					
		}
		
		// Calls the fire method when holding down ctrl or mouse
		void Update () {

		if (TurnManager.whoseturn != 1) {
			return;
		}
		if (ScoreManager.score < 1) {
			return;
		}
		
		if (Input.GetButtonDown("Jump")) {
				Firebullet();

			ScoreManager.score -= 1;
			}
		}
}
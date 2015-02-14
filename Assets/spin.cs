using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour {
	private Vector2 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D righthit = Physics2D.Raycast(transform.position, transform.right, 1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		RaycastHit2D lefthit = Physics2D.Raycast(transform.position, transform.right, -1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		RaycastHit2D uphit = Physics2D.Raycast(transform.position, transform.up, 1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		RaycastHit2D downhit = Physics2D.Raycast(transform.position, transform.up, -1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		
		if (Input.GetButtonDown ("RotateLeft")) {
			RotateLeft();
		}
		else if (Input.GetButtonDown ("RotateRight")) {
			RotateRight();
		}
		else if (Input.GetButtonDown ("Forward")) {

			if (transform.eulerAngles.z > 80 && transform.eulerAngles.z < 100)
					
				{
							
				pos -= Vector2.right;
				transform.position = pos;
																							
					    ScoreManager.score -= 1;
			}

		else if (transform.eulerAngles.z > 170 && transform.eulerAngles.z < 190) {

				if (uphit) {            
					Debug.Log (uphit.collider);
					return;
				}
				pos -= Vector2.up;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 260 && transform.eulerAngles.z < 280) {

				pos += Vector2.right;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 350 || transform.eulerAngles.z < 10) {
				
					if (uphit) {            
						Debug.Log (uphit.collider);
						return;
					}
					pos += Vector2.up;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
		}
		else if (Input.GetButtonDown ("Backward")) {
			if (transform.eulerAngles.z > 80 && transform.eulerAngles.z < 100) {
				pos += Vector2.right;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 170 && transform.eulerAngles.z < 190) {
				pos += Vector2.up;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 260 && transform.eulerAngles.z < 280) {
				pos -= Vector2.right;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 350 || transform.eulerAngles.z < 10) {
				pos -= Vector2.up;
				transform.position = pos;

				ScoreManager.score -= 1;
			}
		}

		else if (Input.GetButtonDown ("Right")) 			
					
			{
			if (transform.eulerAngles.z > 80 && transform.eulerAngles.z < 100) {
				pos += Vector2.up;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 170 && transform.eulerAngles.z < 190) {
				pos -= Vector2.right;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 260 && transform.eulerAngles.z < 280) {
				pos -= Vector2.up;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 350 || transform.eulerAngles.z < 10) {
				pos += Vector2.right;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			}
		else if (Input.GetButtonDown ("Left")) 			
			
		{
			if (transform.eulerAngles.z > 80 && transform.eulerAngles.z < 100) {
				pos -= Vector2.up;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 170 && transform.eulerAngles.z < 190) {
				pos += Vector2.right;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 260 && transform.eulerAngles.z < 280) {
				pos += Vector2.up;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
			else if (transform.eulerAngles.z > 350 || transform.eulerAngles.z < 10) {
				pos -= Vector2.right;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}
		}


	}
	void RotateLeft () {
		transform.Rotate (Vector3.forward * 90);
	}
	void RotateRight () {
		transform.Rotate (Vector3.forward * -90);
	}
}
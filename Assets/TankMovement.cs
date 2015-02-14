using UnityEngine;
using System.Collections;

public class TankMovement : MonoBehaviour {
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
							
				if (uphit) {            
					Debug.Log (uphit.collider);
					return;
				}
				pos += Vector2.up;
				transform.position = pos;
				
				ScoreManager.score -= 1;
								}

		else if (Input.GetButtonDown ("Backward")) {
		
			if (downhit) {            
					Debug.Log (downhit.collider);
					return;
					
				}
				pos -= Vector2.up;
				transform.position = pos;
				
				ScoreManager.score -= 1;

		}
		
		else if (Input.GetButtonDown ("Right")) 			
			
		{
			 
			if (righthit) {            
				Debug.Log(righthit.collider);
				return;
				
			}	
			pos += Vector2.right;
				transform.position = pos;
				
				ScoreManager.score -= 1;

		}
		else if (Input.GetButtonDown ("Left")) 			
									
			 {
			if (lefthit) {            
				Debug.Log (lefthit.collider);
				return;
			}
			pos -= Vector2.right;
				transform.position = pos;
				
				ScoreManager.score -= 1;
			}

		
		
	}
	void RotateLeft () {
		transform.Rotate (Vector3.forward * 90);
	}
	void RotateRight () {
		transform.Rotate (Vector3.forward * -90);
	}
}

using UnityEngine;
using System.Collections;

public class P2NoSpin : MonoBehaviour {
	public LayerMask GroundLayer;
	private Vector2 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
		if (TurnManager.whoseturn != 2) {
			return;
		}
		if (ScoreManager.score == 0) {
						return;
		}
		
		if (Input.GetButtonDown ("RotateLeft")) {
			RotateLeft();
		}
		if (Input.GetButtonDown ("RotateRight")) {
			RotateRight ();
		}
		
		if (Input.GetButtonDown ("Backward")){
			RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1f,1 << LayerMask.NameToLayer("GroundLayer"));
			if(hit.collider != null) return;
			pos -= Vector2.up;
			updateMovement();
		}
		if (Input.GetButtonDown ("Left")){
			RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, 1f,1 << LayerMask.NameToLayer("GroundLayer"));
			if(hit.collider != null) return;
			pos -= Vector2.right;
			updateMovement();
		}
		if (Input.GetButtonDown ("Right")){
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 1f,1 << LayerMask.NameToLayer("GroundLayer"));
			if(hit.collider != null) return;
			pos += Vector2.right;
			updateMovement();
		}
		if (Input.GetButtonDown ("Forward")){
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 1f,1 << LayerMask.NameToLayer("GroundLayer"));
			if(hit.collider != null) return;
			pos += Vector2.up;
			updateMovement();
		}
		
	}
	void updateMovement() {
		transform.position = pos;
		ScoreManager.score -= 1;
	}
	void RotateLeft () {
		transform.Rotate (Vector3.forward * 90);
	}
	void RotateRight () {
		transform.Rotate (Vector3.forward * -90);
	}
}

using UnityEngine;
using System.Collections;

public class LavaSpread : MonoBehaviour {
	public Rigidbody2D lava;
	public LayerMask GroundLayer;
	// Use this for initialization
	void Update () {
		if (Input.GetButtonDown ("Lava")) {
			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.up, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			RaycastHit2D vhit = Physics2D.Raycast (transform.position, Vector2.up, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			RaycastHit2D lhit = Physics2D.Raycast (transform.position, Vector2.up, 1f, 1 << LayerMask.NameToLayer ("LavaLayer"));
			if (hit.collider == null && vhit.collider == null && lhit.collider == null) {
				SpreadUp ();
			}
			hit = Physics2D.Raycast (transform.position, -Vector2.right, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			vhit = Physics2D.Raycast (transform.position, -Vector2.right, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			lhit = Physics2D.Raycast (transform.position, -Vector2.right, 1f, 1 << LayerMask.NameToLayer ("LavaLayer"));
			if (hit.collider == null && vhit.collider == null && lhit.collider == null){
				SpreadLeft ();
			}
			hit = Physics2D.Raycast (transform.position, Vector2.right, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			vhit = Physics2D.Raycast (transform.position, Vector2.right, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			lhit = Physics2D.Raycast (transform.position, Vector2.right, 1f, 1 << LayerMask.NameToLayer ("LavaLayer"));
			if (hit.collider == null && vhit.collider == null && lhit.collider == null){
				SpreadRight ();
			}
			hit = Physics2D.Raycast (transform.position, -Vector2.up, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			vhit = Physics2D.Raycast (transform.position, -Vector2.up, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			lhit = Physics2D.Raycast (transform.position, -Vector2.up, 1f, 1 << LayerMask.NameToLayer ("LavaLayer"));
			if (hit.collider == null && vhit.collider == null && lhit.collider == null){
				SpreadDown ();
			}
		}
	}
	void SpreadUp () {
		Rigidbody2D lavaUp = (Rigidbody2D) Instantiate(lava, transform.position + transform.up*1, transform.rotation);
	}
	void SpreadLeft () {
		Rigidbody2D lavaLeft = (Rigidbody2D) Instantiate(lava, transform.position + transform.right*-1, transform.rotation);
	}
	void SpreadRight () {
		Rigidbody2D lavaRight = (Rigidbody2D) Instantiate(lava, transform.position + transform.right*1, transform.rotation);
	}
	void SpreadDown () {
		Rigidbody2D lavaDown = (Rigidbody2D) Instantiate(lava, transform.position + transform.up*-1, transform.rotation);
	}
}
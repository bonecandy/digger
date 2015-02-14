using UnityEngine;
using System.Collections;

public class LavaButton : MonoBehaviour {
	public Rigidbody2D lava;
	public LayerMask GroundLayer;
	// Use this for initialization
	public void Update () {

			RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.up, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			RaycastHit2D vhit = Physics2D.Raycast (transform.position, Vector2.up, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			if (hit.collider == null && vhit.collider == null) {
			Instantiate(lava, transform.position + transform.up*1, transform.rotation);
			}
			hit = Physics2D.Raycast (transform.position, -Vector2.right, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			vhit = Physics2D.Raycast (transform.position, -Vector2.right, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			if (hit.collider == null && vhit.collider == null){
			Rigidbody2D lavaLeft = (Rigidbody2D) Instantiate(lava, transform.position + transform.right*-1, transform.rotation);
			}
			hit = Physics2D.Raycast (transform.position, Vector2.right, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			vhit = Physics2D.Raycast (transform.position, Vector2.right, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			if (hit.collider == null && vhit.collider == null){
			Rigidbody2D lavaRight = (Rigidbody2D) Instantiate(lava, transform.position + transform.right*1, transform.rotation);
			}
			hit = Physics2D.Raycast (transform.position, -Vector2.up, 1f, 1 << LayerMask.NameToLayer ("GroundLayer"));
			vhit = Physics2D.Raycast (transform.position, -Vector2.up, 1f, 1 << LayerMask.NameToLayer ("VaultLayer"));
			if (hit.collider == null && vhit.collider == null){
			Rigidbody2D lavaDown = (Rigidbody2D) Instantiate(lava, transform.position + transform.up*-1, transform.rotation);
			}

	}

}

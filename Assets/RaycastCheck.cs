using UnityEngine;
using System.Collections;

public class RaycastCheck : MonoBehaviour {
	
	void Update () {
		RaycastHit2D righthit = Physics2D.Raycast(transform.position, transform.right, 1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		RaycastHit2D lefthit = Physics2D.Raycast(transform.position, transform.right, -1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		RaycastHit2D uphit = Physics2D.Raycast(transform.position, transform.up, 1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		RaycastHit2D downhit = Physics2D.Raycast(transform.position, transform.up, -1f, 1 << LayerMask.NameToLayer("GroundLayer"));
		
		if (righthit) {            
			Debug.Log(righthit.collider);
			return;
		
		}
		if (lefthit) {            
						Debug.Log (lefthit.collider);
						return;
				}
		if (uphit) {            
						Debug.Log (uphit.collider);
						return;
				}
		if (downhit) {            
						Debug.Log (downhit.collider);
						return;

				}

	}
}

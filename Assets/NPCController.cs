using UnityEngine;
using System.Collections;

abstract public class NPCController : MonoBehaviour, NPCinterface {

	protected Vector2 pos;
	protected bool  moving = false;
	
	public void ExecuteAI() {

		int direction = Random.Range (1, 5);
		
		if (direction == 1) {
			pos += Vector2.up;
			moving = true;
		}
		else if (direction == 2) {
			pos += Vector2.right;
			moving = true;
		}
		else if (direction == 3) {
			pos -= Vector2.up;
			moving = true;
		}
		else if (direction == 4) {
			pos -= Vector2.right;
			moving = true;
		}
		else {
			; // do nothing
		}
		
	}
}

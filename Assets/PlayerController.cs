using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private GameObject[] npcObjects;
	private NPCController[] npcControllers;
	private Vector2 pos;
	private bool moving = false;
	
	void Start () {
		// First store our current position when the
		// script is initialized.
		pos = transform.position;

		// Find all NPCs with the tag "npc":
		npcObjects = GameObject.FindGameObjectsWithTag ("npc");
		
		npcControllers = new NPCController[npcObjects.Length];
		
		// Iterate through them and store their NPCController to
		// npcControllers array:
		for(int i = 0; i < npcObjects.Length; i++) {
			npcControllers[i] = (NPCController) npcObjects[i]
			.GetComponent(typeof(NPCController));
		}
	}
	
	void Update () {
		
		CheckInput();
		
		if(moving) {
			// pos is changed when there's input from the player
			transform.position = pos;
			moving = false;
		}


	}
	
	private void CheckInput() {
		
		// WASD control
		// We add the direction to our position,
		// this moves the character 1 unit (32 pixels)
		if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && ((pos + Vector2.right).x < 6)) {
			pos += Vector2.right;
			moving = true;
			ExecuteNPCAI();
		}
		
		// For left, we have to subtract the direction
		else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && ((pos - Vector2.right).x >- 10)) {
			pos -= Vector2.right;
			moving = true;
			ExecuteNPCAI();
		}
		else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && ((pos + Vector2.up).y < 16)) {
			pos += Vector2.up;
			moving = true;
			ExecuteNPCAI();
		}
		
		// Same as for the left, subtraction for down
		else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && ((pos - Vector2.up).y > 0)) {
			pos -= Vector2.up;
			moving = true;
			ExecuteNPCAI();
		}
	}

	private void ExecuteNPCAI() {
		foreach(NPCController npc in npcControllers) {
			npc.ExecuteAI();
		}
	}
}
using UnityEngine;
using System.Collections;

public class FirstNPC : NPCController {
	
	void Start () {
		pos = transform.position;
	}
	
	void Update () {
		if (moving) {
			transform.position = pos;
			moving = false;
		} 
	}
}
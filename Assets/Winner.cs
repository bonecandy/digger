using UnityEngine;
using System.Collections;

public class Winner : MonoBehaviour {
	
	
	public void update() {
		
			if(TurnManager.whoseturn == 1 && PowerupManager.p1power > 2) {
			WinManager.whowins += 1;	
		}
		if(TurnManager.whoseturn == 2 && PowerupManager2.p2power > 2) {
			WinManager.whowins += 2;
	}
}
}
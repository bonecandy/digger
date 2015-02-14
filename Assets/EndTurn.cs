using UnityEngine;
using System.Collections;

public class EndTurn : MonoBehaviour {

	public void update() {
		if (TurnManager.whoseturn != 1) {
			return;
		}
		ScoreManager.score += 10;	
		 {
			TurnManager.whoseturn += 1;	
		}
		}
}
using UnityEngine;
using System.Collections;

public class SwapPlayer : MonoBehaviour {
	public void update() {
				if (TurnManager.whoseturn != 2) {
						return;
				}
				ScoreManager.score += 10;
				{
						TurnManager.whoseturn -= 1;	
				}
				
		}


	}

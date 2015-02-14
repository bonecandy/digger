using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerupManager : MonoBehaviour
{
	public static int p1power;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		p1power = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Powerups" followed by the score value.
		text.text = "P1 Powerups: " + p1power;
	}
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerupManager2 : MonoBehaviour
{
	public static int p2power;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		p2power = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Powerups" followed by the score value.
		text.text = "P2 Powerups: " + p2power;
	}
}

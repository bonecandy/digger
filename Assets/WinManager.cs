﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinManager : MonoBehaviour
{
	public static int whowins;        // Whose turn it is.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		whowins = 0;
	}
	
	
	void Update ()
	{
		
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Winner: " + whowins;
	}
}
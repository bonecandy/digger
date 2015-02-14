using UnityEngine;
using System.Collections;

public class ItemSpawner : MonoBehaviour {

	public GameObject Item;
	

	// Use this for initialization
	void Start () {
		// Spawn food every 4 seconds, starting in 3
		Invoke("Spawn", 0);
	}
	
	// Spawn one item
	void Spawn() {
		// x position between left & right border
		int x = (int)Random.Range(-9,
		                          5);
		
		// y position between top & bottom border
		int y = (int)Random.Range(1,
		                          15);
		
		// Instantiate the item at (x, y)
		Instantiate(Item,
		            new Vector2(x, y),
		            Quaternion.identity); // default rotation
	}
}
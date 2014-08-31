using UnityEngine;
using UnityEngine.UI;
using System;

public class ShowKeys : MonoBehaviour {

	Text text;
	string[] keys = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
		"v", "w", "x", "y", "z"};
		
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (string key in keys) {
			if(Input.GetKeyDown(key)){
				text.text += ", D:" + key;
			}
			if(Input.GetKeyUp(key)){
				text.text += ", U:" + key;
			}
		}
	}
}

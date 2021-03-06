using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class colorText : MonoBehaviour {
	public Text text1;

	// Window
	public Transform background;
	public Transform set1;
	public Transform set2;
	public Transform set3;
	//public Transform set4;
	//public Transform set5;
	public Transform close;
	public Transform colorBlack;
	public Transform colorRed;
	public Transform colorCM;

	// Move buttons to avoid accidental presses [as background lacks a BoxCollider2D ]
	public Transform start;
	public Transform rate;
	public Transform howToPlay;
	public Transform colors;

	// Use this for initialization
	void OnMouseDown () {
		text1.text = "";
		background.transform.position = new Vector2 (0, -0.1f);
		set1.transform.position = new Vector2 (0f, 2f);
		set2.transform.position = new Vector2 (0f, 0.5f);
		set3.transform.position = new Vector2 (0f,-1.15f);
		//set4.transform.position = new Vector2 (1.5f, -0.41f);
		colorBlack.transform.position = new Vector2 (0f, 2.5f);
		colorRed.transform.position = new Vector2 (0f, 1f);
		colorCM.transform.position = new Vector2 (0f, -0.5f);
		close.transform.position = new Vector2 (-1.8f, -3.3f);
		start.transform.position = new Vector2 (0, 7);
		rate.transform.position = new Vector2 (0, 8);
		howToPlay.transform.position = new Vector2 (0, 9);
		colors.transform.position = new Vector2 (0, 10);
	}
}

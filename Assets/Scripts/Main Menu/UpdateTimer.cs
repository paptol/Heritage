using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTimer : MonoBehaviour {
	private Text txtRef;
	private float timer;
	// Use this for initialization
	void Start () {
		txtRef = GetComponent<Text> ();
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		string minutes = Mathf.Floor(timer / 60).ToString("00");
		string seconds = (timer % 60).ToString("00");
		txtRef.text = minutes + ":" + seconds;
	}
}

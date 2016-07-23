using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TxtTimeBehavior : MonoBehaviour, TimeListener {

	public TimeManager timeManager;
	Text textComponent;

	// Use this for initialization
	void Start () {
		timeManager.addListener (this);

		textComponent = GetComponent<Text> ();
		textComponent.text = "0";
	}
	public void onTimeChanged(float time) {
		textComponent.text = time.ToString ("F2");
	}

	// Update is called once per frame
	void Update () {
	
	}
}

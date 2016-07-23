using UnityEngine;
using System.Collections;

public class TimeBehavior : MonoBehaviour, TimeListener {

	private Vector3 initialPos;
	public Vector3 finalPos;
	public float initialTime;
	public float finalTime;
	public TimeManager timeManager;

	// Use this for initialization
	void Start () {
		initialPos = transform.position;
		timeManager.addListener (this);
	}

	public void onTimeChanged(float newTime) {
		UpdatePosition(newTime);
	}

	public void UpdatePosition(float time) {
		if (time <= initialTime) {
			transform.position = initialPos;
		} else if (time >= finalTime) {
			transform.position = finalPos;
		} else {
			float x, y, z;
			float alpha = (time - initialTime) / (finalTime - initialTime);
			Vector3 delta = finalPos - initialPos;
			x = initialPos.x + alpha * delta.x;
			y = initialPos.y + alpha * delta.y;
			z = initialPos.z + alpha * delta.z;
			transform.position = new Vector3 (x, y, z);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}

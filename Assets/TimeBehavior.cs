using UnityEngine;
using System.Collections;

public class TimeBehavior : MonoBehaviour {

	private Vector3 initialPos;
	public Vector3 finalPos;
	public float initialTime;
	public float finalTime;
	public float xxxCurrentTime;

	// Use this for initialization
	void Start () {
		initialPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (xxxCurrentTime <= initialTime) {
			transform.position = initialPos;
		} else if (xxxCurrentTime >= finalTime) {
			transform.position = finalPos;
		} else {
			float x, y, z;
			float alpha = (xxxCurrentTime - initialTime) / (finalTime - initialTime);
			Vector3 delta = finalPos - initialPos;
			x = initialPos.x + alpha * delta.x;
			y = initialPos.y + alpha * delta.y;
			z = initialPos.z + alpha * delta.z;
			transform.position = new Vector3 (x, y, z);
		}
	}
}

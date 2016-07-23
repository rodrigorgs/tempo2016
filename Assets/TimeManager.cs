using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public float time;

	private ArrayList timeListeners = new ArrayList ();

	public void addListener(TimeListener tl) {
		timeListeners.Add (tl);
	}
	public void removeListener(TimeListener tl) {
		timeListeners.Remove (tl);
	}
	private void fireEvent() {
		foreach (TimeListener tl in timeListeners) {
			tl.onTimeChanged (time);
		}
	}

	public float GetCurrentTime() {
		return time;
	}

	public void OnValidate() {
		fireEvent ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
}

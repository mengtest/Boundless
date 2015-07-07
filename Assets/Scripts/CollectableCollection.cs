using UnityEngine;
using System.Collections;

public class CollectableCollection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("Something touched me, it was " + other.name);
	}
}

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float     damping;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = target.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float targetX = target.position.x;
		float targetZ = target.position.z;
		float currentX = transform.position.x;
		float currentZ = transform.position.z;

		currentX = Mathf.Lerp(currentX, targetX, damping * Time.deltaTime);
		currentZ = Mathf.Lerp(currentZ, targetZ, damping * Time.deltaTime);

		transform.position = new Vector3(currentX , transform.position.y , transform.position.z);
	}
}

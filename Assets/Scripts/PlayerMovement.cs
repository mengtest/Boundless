using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary {
	public float xMin, xMax, zMin, zMax;
}

public class PlayerMovement : MonoBehaviour {

	public float  speed = 2f;
	public Boundary boundary;

	private Vector3   initialPosition;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		initialPosition = transform.position;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

//		if(h != 0 || v != 0) {
//			Vector3 movement = new Vector3(h * speed, rb.velocity.y, v * speed);
//			rb.velocity = movement;
//		}

		Vector3 force = new Vector3(h * speed, 0f, v * speed);
		rb.AddForce(force, ForceMode.VelocityChange);

		// clamp the z positions so the ball stays on the screen
		rb.position = new Vector3 (
			Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
			rb.position.y,
			Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
			);
	}
}
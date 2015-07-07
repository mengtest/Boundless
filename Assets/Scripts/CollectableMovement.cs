using UnityEngine;
using System.Collections;

public class CollectableMovement : MonoBehaviour {
	
	public float speed;
	public float rotationSpeed;
	public bool  rotating;
	public bool  moving;
	
	private Transform initialTransform;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		initialTransform = transform;
		rb = GetComponent<Rigidbody>();

		if(rotating) {
			rb.angularVelocity = (Vector3.right * rotationSpeed);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(moving) {
			transform.Translate(Vector3.down * Time.time * speed);
		}
//		
//		if(rotating) {
//			transform.Rotate (Vector3.right * Time.deltaTime * rotationSpeed);
//		}
	}
}

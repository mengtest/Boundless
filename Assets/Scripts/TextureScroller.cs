using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextureScroller : MonoBehaviour {


	public float speed = 0.1f;
	public Text  distanceText;

	private Vector2  initialOffset;
	private float    distance;

	private Renderer render;

	// Use this for initialization
	void Start () {
		render = GetComponent<Renderer>();
		distance = 0f;
		initialOffset = render.material.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * speed;


		distance += offset;
		if(distanceText != null) {
			distanceText.text = "Distance: " + (distance/100).ToString("F0") + "cm";
		}

		render.material.SetTextureOffset("_MainTex", new Vector2(initialOffset.x, offset));
	}
}

using UnityEngine;
using System.Collections;

public class bsll_physic : MonoBehaviour {

	public Rigidbody2D rb;
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(new Vector3(0, 10f, 0), ForceMode2D.Impulse);
	}
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3 (
			transform.eulerAngles.x,
			transform.eulerAngles.y,
			90 + -rb.velocity.x
			);
//		rb.velocity = new Vector3 (0, 0, 500f);
//		float y = Terrain.activeTerrain.SampleHeight(transform.position);
//		transform.position = new Vector3(transform.localPosition.x, y + 6 , transform.localPosition.z);
		//transform.localPosition += new Vector3(0, 0.05f, 0);
		Debug.Log (rb.velocity);
		if (rb.velocity.y > 0)
			rb.velocity -= new Vector2 (0, 0.005f);
		if (rb.velocity.x > 0)
			rb.velocity -= new Vector2 (0.005f, 0);
		else
			rb.velocity -= new Vector2 (-0.005f, 0);
	}	
}
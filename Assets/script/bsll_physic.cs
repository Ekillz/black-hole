using UnityEngine;
using System.Collections;

public class bsll_physic : MonoBehaviour {

	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
		//rb.AddForce(transform.forward * 700f, ForceMode.Impulse);
	}
	// Update is called once per frame
	void Update () {
//		rb.velocity = new Vector3 (0, 0, 500f);
		float y = Terrain.activeTerrain.SampleHeight(transform.position);
		transform.position = new Vector3(transform.localPosition.x, y + 6 , transform.localPosition.z);
		transform.localPosition += new Vector3(0, 0, 5f);
	}
}
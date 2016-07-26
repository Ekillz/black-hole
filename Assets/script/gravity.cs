using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0,0, 2));
	}

	void OnTriggerStay2D(Collider2D other) {
		//Debug.Log ("fuck");
		//other.transform.localPosition += new Vector3 (-0.01f, 0, 0);
		other.GetComponent<Rigidbody2D>().AddForce(new Vector3(0.03f, 0.05f, 0) , ForceMode2D.Impulse);
	}
}
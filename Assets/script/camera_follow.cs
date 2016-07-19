using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = player.transform.localPosition; 
		transform.localPosition -= new Vector3 (0, 0, 10);
	}
}

using UnityEngine;
using System.Collections;

public class wold_controller : MonoBehaviour {

	public GameObject[] map;
	public GameObject[] planet;
	public bool play;
	void Start () {
		//Instantiate(map[0],new Vector2 (transform.position.x + 10, transform.position.y + 10), Quaternion.identity);
		play = true;
		StartCoroutine (create_planets ());
	}
	

	void Update () {

	}

	IEnumerator create_planets()
	{
		while (play) {
			Instantiate (planet [Random.Range(0,2)], new Vector2 (transform.position.x + Random.Range (-20, 20), transform.position.y + Random.Range (30, 80)), Quaternion.identity);
			yield return new WaitForSeconds (1);
		}
	}
}
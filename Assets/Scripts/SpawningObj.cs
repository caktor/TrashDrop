using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObj : MonoBehaviour {
	public GameObject[] Trash;
	int TrashNo;
	public float maxPos = 1.9f;
	public float delayTimer = 2f;
	float timer;

	// Use this for initialization
	void Start () {
		timer = delayTimer;

	}
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		if (timer <=0) {
			Vector3 carPos = new Vector3 (Random.Range (-1.9f, 1.9f),transform.position.y, transform.position.z);
			TrashNo = Random.Range (0,5);
			Instantiate (Trash[TrashNo], carPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
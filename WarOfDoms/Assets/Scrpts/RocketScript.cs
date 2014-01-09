using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {
 	
	public float mySpeed;

	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(new Vector3(0,mySpeed * Time.deltaTime,0));
	}
}
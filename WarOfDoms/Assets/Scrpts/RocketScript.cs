using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	public int mySpeed = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(this.transform.position.x,this.transform.position.y + mySpeed * Time.deltaTime);
	}
}

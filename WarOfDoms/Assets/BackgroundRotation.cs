using UnityEngine;
using System.Collections;

public class BackgroundRotation : MonoBehaviour {
	public float myRotationSpeed = 10;
	private float _myRotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_myRotation = this.transform.rotation.x;
		transform.Rotate(0,myRotationSpeed *Time.deltaTime, 0);

	}
}

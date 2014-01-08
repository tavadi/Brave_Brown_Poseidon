using UnityEngine;
using System.Collections;

public class PlayerOneTouchControl : MonoBehaviour {
	private Transform myTransform;
	private Vector3 myDestination;
	private Vector3 myPosition;
	private Vector3 fingerPos;
	private float mySpeed = 10f;
	public Rigidbody2D myRocket;
	// Use this for initialization
	void Start () {
		myTransform = transform;
		myDestination = Camera.main.ScreenToWorldPoint (new Vector3(Screen.height/2,Screen.width/50,0));
		// sets myTransform to this GameObject.transform
	}
	
	
	
	
	void ShootTo(){
		Rigidbody2D rocketClone = (Rigidbody2D) Instantiate(myRocket,new Vector3(myPosition.x, myPosition.y, 0), transform.rotation);
	}
	
	

	// Update is called once per frame
	void Update () {
		myPosition = myTransform.position;
		myPosition.z = 5;
		myTransform.position = Vector2.MoveTowards(myPosition,myDestination,mySpeed*Time.deltaTime);
		
		//ist ein touch am screen?
		//wenn keine touches sind,
		//Debug.DrawLine(new Vector3(0, Screen.height/2, 0), new Vector3(Screen.width, Screen.height/2, 0), Color.red);
		//Debug.DrawLine(new Vector3(0, Screen.height/2, 0), new Vector3(Screen.width, Screen.height/2, 0), Color.red);
		//Debug.Log("myposition"+ myTransform.position);
		//Debug.Log("myDestination"+myDestination);
		if(Input.touchCount > 0){
			for(int i = 0; i < Input.touchCount; i++){
				if(Input.GetTouch(i).position.y > (Screen.height/2 - 100)){
					fingerPos = Input.GetTouch (i).position;
					fingerPos.z = 5;
					myDestination = Camera.main.ScreenToWorldPoint (fingerPos);
				}
			}		
		}
	}
}

using UnityEngine;
using System.Collections;

public class PlayerTwoTouchControl : MonoBehaviour {
	private Transform myTransform;
	private Vector3 myDestination;
	private Vector3 myPosition;
	private Vector3 fingerPos;
	private float mySpeed = 10f;
	public Rigidbody2D myRocket;
	public GUITexture myShootButton;
	// Use this for initialization
	void Start () {
		myTransform = transform;
		// sets myTransform to this GameObject.transform
	}




	public void ShootTo(){
		//Instantiate(myPref, new Vector3(myPosition.x, myPosition.y+10, 0), Quaternion.identity);
		Rigidbody2D rocketClone = (Rigidbody2D) Instantiate(myRocket,new Vector3(myPosition.x, myPosition.y, 0), transform.rotation);
	}



	// Update is called once per frame
	void Update () {
		myPosition = myTransform.position;
		myPosition.z = 5;
		myTransform.position = Vector2.MoveTowards(myPosition,myDestination,mySpeed*Time.deltaTime);

		//ist ein touch am screen?
		//wenn keine touches sind,
		Debug.DrawLine(new Vector3(0, Screen.height/2, 0), new Vector3(Screen.width, Screen.height/2, 0), Color.red);
		Debug.DrawLine(new Vector3(0, Screen.height/2, 0), new Vector3(Screen.width, Screen.height/2, 0), Color.red);
		//Debug.Log("myposition"+ myTransform.position);
		//Debug.Log("myDestination"+myDestination);
		if(Input.touchCount > 0){
			for(int i = 0; i < Input.touchCount; i++){
				if(myShootButton != null && (myShootButton.HitTest(Input.GetTouch(i).position)))
				{
					Debug.Log ("pushed");
					ShootTo();
				}
				else if(Input.GetTouch(i).position.y < Screen.height/2 - 100){
					fingerPos = Input.GetTouch (i).position;
					fingerPos.z = 5;
					myDestination = Camera.main.ScreenToWorldPoint (fingerPos);
				}
			}		
		}
	}
}

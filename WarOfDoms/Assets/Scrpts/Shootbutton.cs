using UnityEngine;
using System.Collections;

public class Shootbutton : MonoBehaviour {


	void Update () 
	{
		//is there a touch on screen?
		if(Input.touches.Length <= 0)
		{
			//if no touches then execute this code
		}
		else //if there is a touch
		{
			//loop through all the the touches on screen
			for(int i = 0; i < Input.touchCount; i++)
			{
				//executes this code for current touch (i) on screen
				if(this.guiTexture != null && (this.guiTexture.HitTest(Input.GetTouch(i).position)))
				{
					//if current touch hits our guitexture, run this code
					if(Input.GetTouch(i).phase == TouchPhase.Began)
					{
						GameObject player = GameObject.FindWithTag("Raumschiff2");
						player.GetComponent<PlayerTwoTouchControl>().ShootTo();
					}

				}
			}
		}

	}
}

using UnityEngine;
using System.Collections;

public class levels : MonoBehaviour {

	public GUISkin credits;

	void Update(){


				if (Input.GetKey (KeyCode.Escape)) {
						Application.Quit ();
				}
		}
		void OnGUI()
		  
	{  GUI.skin = credits;
 		if(GUI.Button (new Rect(Screen.width-300,50,200,100), "Credits"))
			{   			
				Application.LoadLevel(22);
				
				
			}
		}
		
	

	public void onclickplay(int x)
	{  
		Application.LoadLevel(x); 
    }
	public void onclickexit()
	{
				Application.Quit ();
	}

}
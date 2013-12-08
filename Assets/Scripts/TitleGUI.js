var buttonWidth:int = 200;
var buttonHeight:int = 50;
var spacing:int = 100;
function OnGUI(){
	var newHeight:int = Screen.height/2 - buttonHeight/2 - spacing;
		
//	GUILayout.BeginArea(Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - 200, buttonWidth, 400));
//		//Start Game it takes you to the first level
//		if(GUILayout.Button("Start Game", GUILayout.Height(buttonHeight))){
//			Application.LoadLevel("Qbert_1"); 
//		}
//		GUILayout.Space(spacing);
//		//How to Play Button
//		if(GUILayout.Button("How to Play", GUILayout.Height(buttonHeight))){
//			Application.LoadLevel("How_to_play");
//		}
//		GUILayout.Space(spacing);
//		//Options Button
//		if(GUILayout.Button("Options", GUILayout.Height(buttonHeight))){
//			
//		}
//		GUILayout.Space(spacing);
//		//Credits Button
//		if(GUILayout.Button("Credits", GUILayout.Height(buttonHeight))){
//			Application.LoadLevel("Credits");
//		}
//	GUILayout.EndArea();
		//if you click start it takes you to the first level	
	if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, newHeight, buttonWidth, buttonHeight),"Start Game")){
		Application.LoadLevel("Qbert_1"); 
	}
	//Button for options
	if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, newHeight + 50, buttonWidth, buttonHeight),"How to play")){
		Application.LoadLevel("How_to_play");
	}
	if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, newHeight + 100, buttonWidth, buttonHeight),"Options")){
		
	}
	if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, newHeight + 150, buttonWidth, buttonHeight),"Credits")){
		Application.LoadLevel("Credits");
	}
}
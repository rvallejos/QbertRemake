var isPause = false;
var buttonWidth:int = 200;
var buttonHeight:int = 50;

function Update () {
 if( Input.GetKeyDown(KeyCode.P)){
      isPause = !isPause;
   }
   if(isPause)Time.timeScale = 0; //Freeze time
   else Time.timeScale = 1; //resume time
}

function OnGUI(){
	if(isPause){
		if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight/2, buttonWidth, buttonHeight),"Resume")){
			isPause = false;
			//Time.timeScale = 1; //resume the game
		}
		if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight/2 + 100, buttonWidth, buttonHeight),"Return to Main Menu")){
			Application.LoadLevel("Main_Menu"); 
		}
	}
}
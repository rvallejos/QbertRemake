var buttonWidth:int = 200;
var buttonHeight:int = 50;
var creditsHeight:int = 200;
var spacing:int = 100;

function OnGUI(){
	var newHeight:int = Screen.height/2 - creditsHeight/2 - spacing;
	var text = "Programmers:\nVictor Nguyen\nSean Stein\n\nArtist:\nRichard Vallejos\n";
	//credits
	GUI.Label(Rect(Screen.width/2 - buttonWidth/2, newHeight, buttonWidth, creditsHeight),
	text);
	//Button to go back to main menu Programmers:\nVictor Nguyen\nSean Stein\n\nArtist:\nRichard Vallejos\n
	if(GUI.Button(Rect(Screen.width/2 - buttonWidth/2, Screen.height/2 - buttonHeight/2 - spacing + 200, buttonWidth, buttonHeight),"Back")){
		Application.LoadLevel("Main_Menu"); 
	}
}
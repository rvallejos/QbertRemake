using UnityEngine;
using System.Collections;

public class GUISystem : MonoBehaviour {

	delegate void GUIFunction();
	private GUIFunction currentGUI;
	bool isPause = false;
	public int diff = 1;
	int buttonWidth = 200;
	int buttonHeight = 50;
	int creditsHeight = 200;
	int spacing = 100;

	void OnGUI(){
		currentGUI();
	}

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
		currentGUI = MainMenuGUI;
	}

	void Update(){
		if( Input.GetKeyDown(KeyCode.P)){
			isPause = !isPause;
			currentGUI = PauseMenuGUI;
		}
		if(isPause)Time.timeScale = 0; //Freeze time
		else Time.timeScale = 1; //resume time

	}
	void MainMenuGUI(){
		int newHeight = Screen.height/2 - buttonHeight/2 - spacing;

		GUI.Box(new Rect(Screen.width/2 - buttonWidth/2, newHeight - 100, buttonWidth, buttonHeight),
		        "Re*bert");
		//if you click start it takes you to the first level	
		if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, newHeight, buttonWidth, buttonHeight),"Start Game")){
			currentGUI = InGameGUI;
			Application.LoadLevel("Qbert_1"); 
		}
		//Button for How to Play
		if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, newHeight + 50, buttonWidth, buttonHeight),"How to play")){
			currentGUI = InstructionsGUI;
		}
		//Button for Options
		if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, newHeight + 100, buttonWidth, buttonHeight),"Options")){
			currentGUI = OptionsGUI;
		}
		//Button for Credits
		if(GUI.Button(new Rect(Screen.width/2 - buttonWidth/2, newHeight + 150, buttonWidth, buttonHeight),"Credits")){
			currentGUI = CreditsGUI;
		}
	}

	void PauseMenuGUI(){
		if(isPause){
			GUILayout.BeginArea(new Rect(Screen.width / 2.0f - 100, Screen.height/2 - 200, 200, 400));
				if(GUILayout.Button("Resume")){
					isPause = false;
					currentGUI = InGameGUI;
				}
				if(GUILayout.Button("Main Menu")){
					currentGUI = MainMenuGUI;
					Application.LoadLevel("Main_Menu");
				}
			GUILayout.EndArea();
		}
	}

	void InGameGUI(){

	}

	void InstructionsGUI(){
		int newHeight = Screen.height/2 - creditsHeight/2 - spacing;
		string text = "Q – upper-left, W – Up, E – upper-right,\nA – left D – right,\nZ – lower-left, X – down, C – lower-right\nP to Pause.\n\nGoal: Light up all the platforms, while avoiding all the enemies.";

		GUILayout.BeginArea(new Rect(Screen.width / 2.0f - 200, Screen.height/2 - 100, 400, 500));
			GUILayout.Box(text); //controls
			if(GUILayout.Button("Back")){
				currentGUI = MainMenuGUI;
			}
		GUILayout.EndArea();
	}

	void OptionsGUI(){
		GUILayout.BeginArea(new Rect(Screen.width / 2.0f - 100, 200, 200, 500));
			GUILayout.Box("Global Volume: " + string.Format("{0:0.00}", AudioListener.volume));
			AudioListener.volume = GUILayout.HorizontalSlider(AudioListener.volume, 0.0f, 1.0f);
			if(GUILayout.Button("Normal")){
				diff = 1;
			}
			if(GUILayout.Button("Hard")){
				diff = 2;
			}
			if(GUILayout.Button("Back")){
				currentGUI = MainMenuGUI;
			}
		GUILayout.EndArea();
	}

	void CreditsGUI(){
		int newHeight = Screen.height/2 - creditsHeight/2 - spacing;
		string text = "Programmers:\nVictor Nguyen\nSean Stein\n\nArtist:\nRichard Vallejos\n";
		//credits

		//GUILayout.BeginArea(new Rect(Screen.width / 2.0f - 100, 200, 200, 400));
		GUILayout.BeginArea(new Rect(Screen.width / 2.0f - 100, Screen.height/2 - 200, 200, 400));
		GUILayout.Box("Programmers:\nVictor Nguyen\nSean Stein\n\nArtist:\nRichard Vallejos\n");
		if(GUILayout.Button("Back")){
			currentGUI = MainMenuGUI;
		}
		GUILayout.EndArea();

	}
}

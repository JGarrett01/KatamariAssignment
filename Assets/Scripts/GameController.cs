using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	void Awake ()
	{
		Application.LoadLevelAdditive (Scenes.hud);
	}

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	  if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}

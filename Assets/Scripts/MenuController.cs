﻿using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick_Play()
	{
		Application.LoadLevel ("level1");
	}
	
	public void OnClick_Quit()
	{
		Application.Quit();
	}

}

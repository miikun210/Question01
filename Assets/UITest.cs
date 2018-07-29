using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITest : MonoBehaviour {

	public RenderCameraScript renderCameraUI;
	public RenderCameraScript renderCameraWorld;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Click_UI()
	{
		renderCameraWorld.enabled = false;
		renderCameraUI.enabled = true;
	}

	public void Click_World()
	{
		renderCameraUI.enabled = false;
		renderCameraWorld.enabled = true;
	}

	public void Click_Resume()
	{
		renderCameraUI.enabled = false;
		renderCameraWorld.enabled = false;
	}
	
}

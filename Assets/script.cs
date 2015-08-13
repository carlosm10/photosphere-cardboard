using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	public Material entrada;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void NextScene(){
		Application.LoadLevel("sistemas");
	}
	
	public void NextSceneDos(){
		Application.LoadLevel("arco");
	}

	public void ToggleVRMode() {
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
	}
}

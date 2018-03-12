using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PowerOff : MonoBehaviour 
{
	public void OnMouseDown()
	{
		Debug.Log ("Shutting down");
		Application.Quit ();
	}
}

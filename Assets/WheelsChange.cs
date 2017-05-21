using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsChange : MonoBehaviour {

	public GameObject WheelsCariage;
	public GameObject SquareCariage;
	public GameObject FrontSquareWheel;
	public GameObject BackSquareWheel;
	public GameObject FrontRoundWheel;
	public GameObject BackRoundWheel;
	void Start () {
		
	}
	

	void Update () {
		
	}

	public void ChangeToWheels(){


		FrontRoundWheel.GetComponent<Renderer> ().enabled = true;
		BackRoundWheel.GetComponent<Renderer> ().enabled = true;


		FrontSquareWheel.GetComponent<Renderer> ().enabled = false;
		BackSquareWheel.GetComponent<Renderer> ().enabled = false;

		FrontSquareWheel.GetComponent<Collider2D> ().enabled = false;
		BackSquareWheel.GetComponent<Collider2D> ().enabled = false;

		FrontRoundWheel.GetComponent<Collider2D> ().enabled = true;
		BackRoundWheel.GetComponent<Collider2D> ().enabled = true;
	
		 
	}

	public void ChangeSquareWheels(){

		FrontRoundWheel.GetComponent<Renderer> ().enabled = false;
		BackRoundWheel.GetComponent<Renderer> ().enabled = false;

		FrontSquareWheel.GetComponent<Renderer> ().enabled = true;
		BackSquareWheel.GetComponent<Renderer> ().enabled = true;

		FrontSquareWheel.GetComponent<Collider2D> ().enabled = true;
		BackSquareWheel.GetComponent<Collider2D> ().enabled = true;

		FrontRoundWheel.GetComponent<Collider2D> ().enabled = false;
		BackRoundWheel.GetComponent<Collider2D> ().enabled = false;


	}




}

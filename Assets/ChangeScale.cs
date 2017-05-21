using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour {


	public GameObject w1;
	public GameObject w2;
	public GameObject Frontroundwheels;
	public GameObject Backroundwheels;
	public GameObject ExtraW2;
	public GameObject NewFrontWheel;
	public GameObject NewBackWheel;
	float changelength =0.0f;
	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		//w1.transform.localScale = new Vector3 (0.25f+changelength,0.25f,0.25f);
		//w2.transform.localScale = new Vector3 (0.25f+changelength,0.25f,0.25f);
		//ExtraW2.transform.localScale = new Vector3 (0.25f+changelength,0.25f,0.25f);
		NewFrontWheel.transform.localScale = new Vector3 (0.25f+changelength,0.25f+changelength,0.25f);
		NewBackWheel.transform.localScale = new Vector3 (0.25f+changelength,0.25f+changelength,0.25f);
		//Frontroundwheels.transform.localScale = new Vector3 (0.25f+changelength,0.25f+changelength,0.25f);
		//Backroundwheels.transform.localScale = new Vector3 (0.25f+changelength,0.25f+changelength,0.25f);
	}

	public void changes(float newscale){

		changelength= newscale;
		Debug.Log (changelength);
	}
}

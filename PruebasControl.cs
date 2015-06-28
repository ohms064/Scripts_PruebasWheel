using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PruebasControl : MonoBehaviour {
	public Text volante;
	public Text pedal;
	public Text freno;
	public Text clutch;

	public float value;
	public bool value2;
	public Text mapeo;
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void Update () {
		volante.text = "Volante: " + Input.GetAxis("Horizontal").ToString("F2");
		pedal.text = "Acelerador: " + Input.GetAxis("Vertical").ToString("F2");
		freno.text = "Freno: " + Input.GetAxis("Vertical").ToString("F2");
		clutch.text = "Clutch: " + Input.GetAxis("Clutch").ToString("F2");

		int i = 0;
		while (i < 20) {
			if(Input.GetKey("joystick button " + i))
				mapeo.text = Input.GetKey("joystick button " +i) + " " + i; 

			i++;
		}	

	}
}

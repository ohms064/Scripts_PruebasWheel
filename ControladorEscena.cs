using UnityEngine;
using System.Collections;

public class ControladorEscena : MonoBehaviour {
	public string nombreCarro;
	public static GameObject carro;

	// Use this for initialization
	void Awake () {
		carro = GameObject.Find ( nombreCarro );
	}
	
	// Update is called once per frame
	void Update () {
	}
}

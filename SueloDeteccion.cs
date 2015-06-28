using UnityEngine;
using System.Collections;

public class SueloDeteccion : MonoBehaviour {

	void Awake(){
		if (this.transform.childCount > 0) {
			for (int i = 0; i< this.transform.childCount; i++) {
				this.transform.GetChild (i).GetComponent<BoxCollider> ().enabled = false;
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter( Collision coll ){
		if (this.transform.childCount > 0 && coll.gameObject.name == ControladorEscena.carro.name ) {
			for (int i = 0; i< this.transform.childCount; i++) {
				this.transform.GetChild (i).GetComponent<BoxCollider> ().enabled = true;
			}
		}
	}
	void OnCollisionExit( Collision coll ){
		if (this.transform.childCount > 0 && coll.gameObject.name == ControladorEscena.carro.name ) {
			for (int i = 0; i< this.transform.childCount; i++) {
				this.transform.GetChild (i).GetComponent<BoxCollider> ().enabled = false;
			}
		}
	}
}

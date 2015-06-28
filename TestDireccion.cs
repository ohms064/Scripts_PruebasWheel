using UnityEngine;
using System.Collections;

public class TestDireccion : MonoBehaviour {
	[HideInInspector]
	public Vector3 direccionSuelo;
	[HideInInspector]
	public float vParalelo; //resultado del producto punto
	public float limiteIzqDer;
	
	void Update () {
		//producto punto entre los trigger del suelo(suelo actual)
		vParalelo = Vector3.Dot ( this.transform.forward , direccionSuelo );
		if (vParalelo > limiteIzqDer)
			print ("vas bien "+vParalelo);
		else
			print ("vas mal "+vParalelo);
	}
}

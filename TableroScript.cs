using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TableroScript : MonoBehaviour {

	public Image rmp;
	public Image gas;
	public Image temp;
	public Image acelerometro;
	[Range(0f,150f)]
	public float valorRef;

	private const float anguloMaximo = -210f;
	private const float anguloMinimo = 30f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		/*
		RotacionImagenes ( rmp , valorRef , 150f ,  anguloMaximo);
		RotacionImagenes ( gas , valorRef , 150f , -60 );
		RotacionImagenes ( temp , valorRef , 150f , -60 );
		RotacionImagenes ( acelerometro , valorRef , 150f , anguloMaximo );
		*/
		RotacionImagenes ( rmp , anguloMinimo,  anguloMaximo, 0f, 150f, valorRef);
		RotacionImagenes ( gas , anguloMinimo,  anguloMaximo, 0f, 150f, 40f );
		RotacionImagenes ( temp , anguloMinimo,  anguloMaximo, 0f, 150f, 30f );
		RotacionImagenes ( acelerometro, anguloMinimo,  anguloMaximo, 0f, 150f, valorRef );
		
	}
	//Joaquin
	/* 
	public void RotacionImagenes( Image img , float valorRef , float valRefMax , float angMaxImagen ){
		float angulo = (valorRef*angMaxImagen)/valRefMax;
		img.GetComponent<RectTransform> ().localEulerAngles = new Vector3(img.GetComponent<RectTransform> ().localEulerAngles.x , img.GetComponent<RectTransform> ().localEulerAngles.y , angulo);
	}
	*/

	//Omar
	public void RotacionImagenes( Image img , float gradMin, float gradMax, float velMin, float velMax, float valor){
		float angulo = getAngulo (gradMin, gradMax, velMin, velMax, valor);
		img.GetComponent<RectTransform> ().localEulerAngles = new Vector3(img.GetComponent<RectTransform> ().localEulerAngles.x , img.GetComponent<RectTransform> ().localEulerAngles.y , angulo);
	}


	private float pendiente(float gradMin, float gradMax, float velMin, float velMax){
		return (gradMax - gradMin)/(velMax - velMin);
	}

	public float getAngulo(float gradMin, float gradMax, float velMin, float velMax, float valVelocidad){
		//La posicion inicial de la flecha debe ser 0°
		return (pendiente (gradMin, gradMax, velMin, velMax) * (valVelocidad-velMin)) + gradMin;
	}
}

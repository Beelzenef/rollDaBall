using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCam : MonoBehaviour {

    public GameObject jugadorcito;
    private Vector3 posicionRelativaJugador;

	// Use this for initialization
	void Start () {
        posicionRelativaJugador = transform.position - jugadorcito.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = jugadorcito.transform.position + posicionRelativaJugador;
	}
}

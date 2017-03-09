using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroItem : MonoBehaviour {

    Vector3 rotacion;

	// Use this for initialization
	void Start () {
        rotacion = new Vector3(15, 30, 45);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rotacion * Time.deltaTime);
	}
}

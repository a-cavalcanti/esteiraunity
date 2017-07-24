using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorObjeto : MonoBehaviour {

	public GameObject objeto;
	private float timeCounter = 0f;

	void Update () {

		timeCounter += Time.deltaTime;

		if (timeCounter > 5f) {
			Instantiate (objeto, new Vector3 (4.608f, 2.32f, 0), objeto.transform.rotation);
			timeCounter = 0f;
		}
	}
}

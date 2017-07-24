using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour {

	public float speed = 1.0f;

	void OnTriggerStay(Collider collider){
		collider.transform.position += transform.forward * speed * Time.deltaTime;
	}
}

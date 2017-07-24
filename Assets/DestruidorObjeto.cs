using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruidorObjeto : MonoBehaviour {

	public void OnTriggerEnter(Collider collider){
		if(collider.gameObject.name.Equals("CubeNovo(Clone)"))
			Destroy (collider.gameObject);
	}
}

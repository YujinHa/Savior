using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {
	
	public GameObject title;

	void Start () {
		
	}

	void Update () {
		title.transform.localScale += new Vector3 (0.01f,0.01f,0f);
	}
}

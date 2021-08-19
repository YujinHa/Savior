using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDontDestroy : MonoBehaviour {

	static public SoundDontDestroy instance;

	void Start () {
		if (instance == null) {
			DontDestroyOnLoad (this.gameObject);
			instance = this;
		} else {//
			Destroy (this.gameObject);//
			instance.gameObject.SetActive (true);
		}
	}
	void Update () {
		
	}
}

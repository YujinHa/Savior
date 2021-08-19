using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic1 : MonoBehaviour {

	private AudioSource audioSrc;
	private float musicVolume = 1f;
	public int sound3 = 0;
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}

	void Update () {
		audioSrc.volume = musicVolume;

		if (sound3 == 1) {
			audioSrc.loop = false;
			audioSrc.Play ();
			sound3 = 0;
		}
	}
	public void SetVolume (float vol) {
		musicVolume = vol;
	}
}

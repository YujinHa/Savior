using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic2 : MonoBehaviour {
	private AudioSource audioSrc;
	private float musicVolume = 1f;
	public int sound6 = 0;
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}

	void Update () {
		audioSrc.volume = musicVolume;

		if (sound6 == 1) {
			audioSrc.loop = false;
			audioSrc.Play ();
			sound6 = 0;
		}
	}
	public void SetVolume (float vol) {
		musicVolume = vol;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion2 : MonoBehaviour {
	private AudioSource audioSrc;
	private float musicVolume = 1f;
	public int sound5 = 0;
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}

	void Update () {
		audioSrc.volume = musicVolume;

		if (sound5 == 1) {
			audioSrc.loop = false;
			audioSrc.Play ();
			sound5 = 0;
		}
	}
	public void SetVolume (float vol) {
		musicVolume = vol;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : MonoBehaviour {
	private AudioSource audioSrc;
	private float musicVolume = 1f;
	public int sound4 = 0;
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}

	void Update () {
		audioSrc.volume = musicVolume;

		if (sound4 == 1) {
			audioSrc.loop = false;
			audioSrc.Play ();
			sound4 = 0;
		}
	}
	public void SetVolume (float vol) {
		musicVolume = vol;
	}
}

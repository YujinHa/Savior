using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class melee : MonoBehaviour {
	private AudioSource audioSrc;
	private float musicVolume = 1f;
	public int sound1 = 0;
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}

	void Update () {
		audioSrc.volume = musicVolume;

		if (sound1 == 1) {
			audioSrc.loop = false;
			audioSrc.Play ();
			sound1 = 0;
		}
	}
	public void SetVolume (float vol) {
		musicVolume = vol;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour {

	private AudioSource Audio1;
	public AudioClip attackSound;
	private AudioSource Audio2;
	public AudioClip DynamiteSound;
	private AudioSource Audio3;
	public AudioClip teleportSound;
	private AudioSource Audio4;
	public AudioClip attackSound2;
	private AudioSource Audio5;
	public AudioClip DynamiteSound2;
	private AudioSource Audio6;
	public AudioClip teleportSound2;
	private float musicVolume = 1f;

	public int sound1 = 0;
	public int sound2 = 0;
	public int sound3 = 0;
	public int sound4 = 0;
	public int sound5 = 0;
	public int sound6 = 0;

	void Start () {
		Audio1 = gameObject.AddComponent<AudioSource> ();
		Audio1.clip = attackSound;
		Audio2 = gameObject.AddComponent<AudioSource> ();
		Audio2.clip = DynamiteSound;
		Audio3 = gameObject.AddComponent<AudioSource> ();
		Audio3.clip = teleportSound;
		Audio4 = gameObject.AddComponent<AudioSource> ();
		Audio4.clip = attackSound2;
		Audio5 = gameObject.AddComponent<AudioSource> ();
		Audio5.clip = DynamiteSound2;
		Audio6 = gameObject.AddComponent<AudioSource> ();
		Audio6.clip = teleportSound2;
	}

	void Update () {
		Audio1.volume = musicVolume;
		Audio2.volume = musicVolume;
		Audio3.volume = musicVolume;
		Audio4.volume = musicVolume;
		Audio5.volume = musicVolume;
		Audio6.volume = musicVolume;

		if (sound1 == 1) {
			Audio1.loop = false;
			Audio1.Play ();
			sound1 = 0;
		}
		if (sound2 == 1) {
			Audio2.loop = false;
			Audio2.Play ();
			sound2 = 0;
		}
		if (sound3 == 1) {
			Audio3.loop = false;
			Audio3.Play ();
			sound3 = 0;
		}
		if (sound4 == 1) {
			Audio4.loop = false;
			Audio4.Play ();
			sound4 = 0;
		}
		if (sound5 == 1) {
			Audio5.loop = false;
			Audio5.Play ();
			sound5 = 0;
		}
		if (sound6 == 1) {
			Audio6.loop = false;
			Audio6.Play ();
			sound6 = 0;
		}
	}
	public void SetVolume (float vol) {
		musicVolume = vol;
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ally3 : MonoBehaviour {
	[HideInInspector]
	public bool facingRight = true;

	private Animator anim;
	public GameObject attackrange;
	public float speed = 10f;
	public float HP = 1.0f;
	public GameObject healthbar;
	Vector3 localScale;

	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () {
		anim = GetComponent<Animator>();
		attackrange = GameObject.FindWithTag("AttackRadius_A3");
		attackrange.SetActive (false);
		HP = 1.0f;
		localScale = healthbar.transform.localScale;
	}

	void Update () {
		attackrange.SetActive (false);
		float dir = Vector2.Distance(GameObject.Find ("Swordsman").GetComponent<Player1> ().transform.position,transform.position);
		if(Mathf.Abs(dir) <= 2f && (Time.time > nextTime))
		{
			nextTime = (Time.time + TimeLeft);
			anim.SetTrigger("attack");
			attackrange.SetActive (true);
			GameObject.Find ("Swordsman").GetComponent<Player1> ().HP -= 0.1f;
		}
		if (HP <= 0f) {
			anim.SetTrigger ("die");
			Destroy (gameObject);
		}
		if (GameObject.Find ("Swordsman").GetComponent<Player1_item> ().bombcheck == 1) {
			Destroy (this.gameObject);
		}
		if ((GameObject.Find ("Swordsman").GetComponent<Player1> ().transform.position.x - transform.position.x >= 0) && !facingRight)
			flip ();
		else if((GameObject.Find ("Swordsman").GetComponent<Player1> ().transform.position.x- transform.position.x < 0) && facingRight)
			flip ();
		if (HP >= 0) {
			localScale.x = HP;
			healthbar.transform.localScale = localScale;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("1RangedAttack"))
			HP -= 0.05f;
	}

	void flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}

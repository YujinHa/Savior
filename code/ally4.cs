using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ally4 : MonoBehaviour {
	[HideInInspector]
	public bool facingRight = true;

	public GameObject bomb;
	public float speed = 100f;
	public float HP = 1.0f;
	public GameObject healthbar;
	Vector3 localScale;
	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () {
		bomb.SetActive (false);
		HP = 1.0f;
		localScale = healthbar.transform.localScale;
	}

	void Update () {
		float dir_x = GameObject.Find ("Swordsman").GetComponent<Player1> ().transform.position.x-transform.position.x;
		float dir_y = GameObject.Find ("Swordsman").GetComponent<Player1> ().transform.position.y-transform.position.y;
		if(Mathf.Abs(dir_y) <= 0.4f && Mathf.Abs(dir_x) <= 4f && (Time.time > nextTime))
		{
			nextTime = (Time.time + TimeLeft);
			bomb.transform.position = transform.position;
			bomb.SetActive (true);
			bomb.GetComponent<bomb>().bombAttack (new Vector3 (GameObject.Find ("Swordsman").transform.position.x, GameObject.Find ("Swordsman").transform.position.y, 0f));
		}
		if (HP <= 0f) 
			Destroy (gameObject);
		if (GameObject.Find ("Swordsman").GetComponent<Player1_item> ().bombcheck == 1) {
			Destroy (gameObject);
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
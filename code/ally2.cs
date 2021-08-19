using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ally2 : MonoBehaviour {
	[HideInInspector]
	public bool facingRight = true;

	public GameObject arrow1;
	public float speed = 100f;
	public float HP = 1.0f;
	public GameObject healthbar;
	Vector3 localScale;
	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () {
		arrow1.SetActive (false);
		HP = 1.0f;
		localScale = healthbar.transform.localScale;
	}

	void Update () {
		float dir_x = GameObject.Find ("Goblin").GetComponent<Player2> ().transform.position.x-transform.position.x;
		float dir_y = GameObject.Find ("Goblin").GetComponent<Player2> ().transform.position.y-transform.position.y;
		if(Mathf.Abs(dir_y) <= 0.4f && Mathf.Abs(dir_x) <= 4f && (Time.time > nextTime))
		{
			nextTime = (Time.time + TimeLeft);
			arrow1.transform.position = transform.position;
			arrow1.SetActive (true);
			arrow1.GetComponent<arrow> ().arrowAttack (new Vector3 (GameObject.Find ("Goblin").transform.position.x, GameObject.Find ("Goblin").transform.position.y, 0f));
		}
		if (HP <= 0f) 
			Destroy (gameObject);
		if (GameObject.Find ("Goblin").GetComponent<Player2_item> ().bombcheck == 1) {
			Destroy (gameObject);
		}
		if ((GameObject.Find ("Goblin").GetComponent<Player2> ().transform.position.x - transform.position.x >= 0) && !facingRight)
			flip ();
		else if((GameObject.Find ("Goblin").GetComponent<Player2> ().transform.position.x- transform.position.x < 0) && facingRight)
			flip ();
		if (HP >= 0) {
			localScale.x = HP;
			healthbar.transform.localScale = localScale;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("2RangedAttack"))
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
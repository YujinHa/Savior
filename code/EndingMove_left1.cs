using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingMove_left1 : MonoBehaviour {

	public Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Update () {
		rb2d.AddForce (0.05f*Vector2.right,ForceMode2D.Impulse);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2Controller : MonoBehaviour 
{
	public GameObject player;

	private Vector3 offset;
	private Vector3 temp;

	void Start()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate()
	{
		temp = player.transform.position + offset;
		if (temp.x < (-31.38)) {
			if ((temp.y >= (-3.24)) && (temp.y <= (3.24)))
				transform.position = new Vector3 (-31.38f, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -3.24)
				transform.position = new Vector3 (-31.38f, -3.24f, transform.position.z);
			else if (temp.y > 3.24)
				transform.position = new Vector3 (-31.38f, 3.24f, transform.position.z);
		} else if (temp.x > 31.2) {
			if ((temp.y >= (-3.24)) && (temp.y <= (3.24)))
				transform.position = new Vector3 (31.2f, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -3.24)
				transform.position = new Vector3 (31.2f, -3.24f, transform.position.z);
			else if (temp.y > 3.24)
				transform.position = new Vector3 (31.2f, 3.24f, transform.position.z);
		} else {
			if ((temp.y >= (-3.24)) && (temp.y <= (3.24)))
				transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -3.24)
				transform.position = new Vector3 (player.transform.position.x + offset.x, -3.24f, transform.position.z);
			else if (temp.y > 3.24)
				transform.position = new Vector3 (player.transform.position.x + offset.x, 3.24f, transform.position.z);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3Controller : MonoBehaviour 
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
		if (temp.x < (-10.55)) {
			if ((temp.y >= (-11.1)) && (temp.y <= (11.1)))
				transform.position = new Vector3 (-10.55f, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -11.1)
				transform.position = new Vector3 (-10.55f, -11.1f, transform.position.z);
			else if (temp.y > 3.24)
				transform.position = new Vector3 (-10.55f, 11.1f, transform.position.z);
		} else if (temp.x > 10.4) {
			if ((temp.y >= (-11.1)) && (temp.y <= (11.1)))
				transform.position = new Vector3 (10.4f, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -11.1)
				transform.position = new Vector3 (10.4f, -11.1f, transform.position.z);
			else if (temp.y > 11.1)
				transform.position = new Vector3 (10.4f, 11.1f, transform.position.z);
		} else {
			if ((temp.y >= (-11.1)) && (temp.y <= (11.1)))
				transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -11.1)
				transform.position = new Vector3 (player.transform.position.x + offset.x, -11.1f, transform.position.z);
			else if (temp.y > 11.1)
				transform.position = new Vector3 (player.transform.position.x + offset.x, 11.1f, transform.position.z);
		}
	}
}

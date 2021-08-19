using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera4Controller : MonoBehaviour 
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
		if (temp.x < (-6.4)) {
			if ((temp.y >= (-31.96)) && (temp.y <= (31.96)))
				transform.position = new Vector3 (-6.4f, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -31.96)
				transform.position = new Vector3 (-6.4f, -31.96f, transform.position.z);
			else if (temp.y > 31.96)
				transform.position = new Vector3 (-6.4f, 31.96f, transform.position.z);
		} else if (temp.x > 6.23) {
			if ((temp.y >= (-31.96)) && (temp.y <= (31.96)))
				transform.position = new Vector3 (6.23f, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -31.96)
				transform.position = new Vector3 (6.23f, -31.96f, transform.position.z);
			else if (temp.y > 31.96)
				transform.position = new Vector3 (6.23f, 31.96f, transform.position.z);
		} else {
			if ((temp.y >= (-31.96)) && (temp.y <= (31.96)))
				transform.position = new Vector3 (player.transform.position.x + offset.x, player.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -31.96)
				transform.position = new Vector3 (player.transform.position.x + offset.x, -31.96f, transform.position.z);
			else if (temp.y > 31.96)
				transform.position = new Vector3 (player.transform.position.x + offset.x, 31.96f, transform.position.z);
		}
	}
}

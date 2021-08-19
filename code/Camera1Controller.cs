using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1Controller : MonoBehaviour 
{
    public GameObject player1;

    private Vector3 offset;
    private Vector3 temp;

    void Start()
    {
        offset = transform.position - player1.transform.position;
    }

    void LateUpdate()
    {
        temp = player1.transform.position + offset;
		if (temp.x < (-10.6)) {
			if ((temp.y >= (-2.8)) && (temp.y <= (2.8)))
				transform.position = new Vector3 (-10.6f, player1.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -2.8)
				transform.position = new Vector3 (-10.6f, -2.8f, transform.position.z);
			else if (temp.y > 2.8)
				transform.position = new Vector3 (-10.6f, 2.8f, transform.position.z);
		} else if (temp.x > 10.5) {
			if ((temp.y >= (-2.8)) && (temp.y <= (2.8)))
				transform.position = new Vector3 (10.5f, player1.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -2.8)
				transform.position = new Vector3 (10.5f, -2.8f, transform.position.z);
			else if (temp.y > 2.8)
				transform.position = new Vector3 (10.5f, 2.8f, transform.position.z);
		} else {
			if ((temp.y >= (-2.8)) && (temp.y <= (2.8)))
				transform.position = new Vector3 (player1.transform.position.x + offset.x, player1.transform.position.y + offset.y, transform.position.z);
			else if (temp.y < -2.8)
				transform.position = new Vector3 (player1.transform.position.x + offset.x, -2.8f, transform.position.z);
			else if (temp.y > 2.8)
				transform.position = new Vector3 (player1.transform.position.x + offset.x, 2.8f, transform.position.z);
		}
	}
}

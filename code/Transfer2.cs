using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transfer2 : MonoBehaviour
{

    public string Stage2;
	public string EndingStage;

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
			GameObject.Find ("bar").GetComponent<underbar> ().life2--;

			if (GameObject.Find ("bar").GetComponent<underbar> ().life2 == 0) {
			//	Destroy (GameObject.Find ("Controllbar"));
				SceneManager.LoadScene (EndingStage);
			}
			else
				SceneManager.LoadScene (Stage2);
        }
    }
}

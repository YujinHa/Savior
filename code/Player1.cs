using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    [HideInInspector]
    public bool facingRight = true;

	public Rigidbody2D rb2d;
    public float moveForce = 6f;
    private Animator anim;
	public GameObject healthbar;
	Vector3 localScale;
	float dietime = 0f;

	public float HP;
	public int die = 0;
	public string Stage2;
	public string EndingStage;

	public GameObject Net;
	public GameObject attackrange;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
		HP = 2.5f;
        rb2d = GetComponent<Rigidbody2D>();
		Net = GameObject.Find ("Goblin").GetComponent<Player2_item> ().Net2;
		attackrange = GameObject.FindWithTag("AttackRadius");
		localScale = healthbar.transform.localScale;
		attackrange.SetActive (false);
    }
	void Update()
    {
		if ((HP <= 0.1f) && (die == 0) && (GameObject.Find ("Goblin").GetComponent<Player2> ().die==0)) {
			die = 1;
			anim.SetTrigger ("die");
			GameObject.Find ("bar").GetComponent<underbar> ().life1--;
		} else if ((HP <= 0.1f) && (die == 1)) {
			dietime = dietime + Time.deltaTime;
			if (dietime >= 0.8f) {
				if (GameObject.Find ("bar").GetComponent<underbar> ().life1 == 0) {
					SceneManager.LoadScene (EndingStage);
				}
				else
					SceneManager.LoadScene (Stage2);
			}
		}
    }
    void FixedUpdate()
    {
		attackrange.SetActive (false);
        float h = 0.0f;
        Vector2 moveVelocity = Vector2.zero;

		if (Input.GetKey(KeyCode.D) && (Net.activeSelf == false))
        {
            h = 0.20f;
            moveVelocity = Vector2.right;
			if (rb2d.velocity.x < 5.0f) {
				rb2d.AddForce (moveForce*moveVelocity,ForceMode2D.Impulse);
			}
        }
		if (Input.GetKey(KeyCode.A) && (Net.activeSelf==false))
        {
            h = -0.20f;
            moveVelocity = Vector2.left;
			if (rb2d.velocity.x > -5.0f) {
				rb2d.AddForce (moveForce*moveVelocity,ForceMode2D.Impulse);
			}
        }
		if (Input.GetKeyDown(KeyCode.Tab) && (Net.activeSelf==false))
        {
            anim.SetTrigger("attack");
			attackrange.SetActive (true);

			GameObject.Find ("melee").GetComponent<melee> ().sound1 = 1;//
        }

        if (h > 0 && !facingRight)
            Flip();

        else if (h < 0 && facingRight)
            Flip();

		if (HP >= 0) {
			localScale.x = HP;
			healthbar.transform.localScale = localScale;
		}
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("2RangedAttack"))
			HP -= 0.1f;
		
		if (col.gameObject.tag == "AttackRadius_A4") {
			if (GameObject.Find ("Goblin").GetComponent<Player2_item> ().arrowcheck == 1)
				HP -= 0.2f;
			else
				HP -= 0.1f;
			col.gameObject.SetActive (false);
		}

		if(col.gameObject.tag == "AttackRadius_A3") {
			if (GameObject.Find ("Goblin").GetComponent<Player2_item> ().arrowcheck == 1)
				HP -= 0.2f;
			else
				HP -= 0.1f;
		}
	}
}

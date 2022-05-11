using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player1Controller : MonoBehaviour
{

	public Animator anim;
/*	public bool Beat;
	AudioSource beats;
	public float BeatsPerSecond;
	public Transform AttackPoint;
	public float attackRange = 0.5f;
	public LayerMask enemyLayers;
*/
	// Controls facing direction
	public bool facingRight;

	// Use this for initialization
	void Start()
	{
/*		beats = GetComponent<AudioSource>();
		beats.Play();
*/
	}
	 
	public void Jump()
    {
		anim.SetBool("Jump", true) ;
	}

	public void JumpOff()
    {
		anim.SetBool("Jump", false);
	}

	public void Dead()
	{
		anim.SetBool("Dead" , true);
	}

	public void DeadOff()
	{
		anim.SetBool("Dead", false);
	}
	public void Walk()
	{
		anim.SetBool("Walk" , true);
	}

	public void WalkOff()
	{
		anim.SetBool("Walk", false);
	}
	public void Run()
	{
		anim.SetBool("Run" , true);
	}
	public void RunOff()
	{
		anim.SetBool("Run", false);
	}
	public void Attack()
	{
		anim.SetBool("Attack" , true);
/*	Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);
		foreach(Collider2D enemy in hitEnemies)
		{
			Debug.Log("Hit" + enemy.name);
		}
*/
	}
	public void AttackOff()
	{
		anim.SetBool("Attack", false);
	}





	void Update()
	{
		if(Input.GetKeyDown (KeyCode.D)||Input.GetKeyDown (KeyCode.A)){Walk();}
		if(Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)){WalkOff();}
/*		if(Beat = true && Input.GetKeyDown (KeyCode.Space)){Attack();}
		if(Beat = true && Input.GetKeyUp (KeyCode.Space)){AttackOff();}
		StartCoroutine(BPM());
*/
	}

/*	private IEnumerator BPM()
	{
		while(true)
		{
			//Beat = false;
			yield return new WaitForSeconds(BeatsPerSecond);
			//Beat = true;
		}
	}
	 void OnDrawGizmosSelected()
	 {
		 if(AttackPoint == null)
		 {
			 return;
		 }
		 Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
	 }
	*/
}




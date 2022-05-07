using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dartMovement : MonoBehaviour
{
	public int damage = 1;
	public float speed =20f;
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){

    	Ballon balloon = hitInfo.GetComponent<Ballon>();

    	if(balloon != null){

    		balloon.TakeDamage(damage);

    	}
			//Debug.Log(gameObject);
    	Destroy(gameObject);


    }
}

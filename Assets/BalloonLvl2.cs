
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BalloonLvl2 : MonoBehaviour
{
	public int health = 1;
	public GameObject deathEffect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void TakeDamage(int damage){

    	health -=damage;
    	if(health <=0){

    	Destroy(gameObject);
      
         SceneManager.LoadScene("Menu");
    	}
    }
}

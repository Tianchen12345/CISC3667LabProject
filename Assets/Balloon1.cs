using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Balloon1 : MonoBehaviour
{
	[SerializeField] GameObject controller;
	[SerializeField] AudioSource audio;
	public GameObject Balloon;
	public int health = 1;
	public GameObject deathEffect;
	float scale=.001f;
    // Start is called before the first frame update
    void Start()
    {
				Debug.Log(Balloon);
				if(controller =null){

					controller=GameObject.FindGameObjectWithTag("GameController");
				}
         if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
				scale+=.00005f;
        Balloon.transform.localScale+= new Vector3(3*Time.deltaTime*scale,3*Time.deltaTime*scale,0f);

					if(scale>=.06f){
						Destroy(gameObject);
						SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
    }


    public void TakeDamage(int damage){

    	health -=damage;
    	if(health <=0){
    		AudioSource.PlayClipAtPoint(audio.clip, transform.position);
				Debug.Log(controller);
				Debug.Log(gameObject);
				controller.GetComponent<ScoreKeeper>().UpdateScore();

    		Destroy(gameObject);

  		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    	}
    }
}

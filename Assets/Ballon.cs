using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ballon : MonoBehaviour
{
	[SerializeField] GameObject controller;
	[SerializeField] AudioSource audio;
	public GameObject Balloon;
	public int health = 1;
	public GameObject deathEffect;
	float scale=.001f;
	double score=20;
	int SaveScore;
    // Start is called before the first frame update
    void Start()
    {

				if(controller =null){

					controller=GameObject.FindGameObjectWithTag("GameController");
				}
         if (audio == null)
        {
            audio = GetComponent<AudioSource>();
        }
				SaveScore=PersistentData.Instance.GetScore();
    }

    // Update is called once per frame
    void Update()
    {
			if(Balloon != null){
				scale+=.00004f;
        Balloon.transform.localScale+= new Vector3(3*Time.deltaTime*scale,3*Time.deltaTime*scale,0f);
				score -=1.5 * 2*Time.deltaTime;
				PersistentData.Instance.SetScore((int)score);
					if(score<=0){
						Destroy(gameObject);
						score=SaveScore;
						PersistentData.Instance.SetScore((int)score);
					SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
		}
    }


    public void TakeDamage(int damage){

    	health -=damage;
    	if(health <=0){
    		AudioSource.PlayClipAtPoint(audio.clip, transform.position);
				score=PersistentData.Instance.GetScore();
				controller.GetComponent<ScoreKeeper>().UpdateScore((int)score);

    		Destroy(gameObject);

  		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    	}
    }
}

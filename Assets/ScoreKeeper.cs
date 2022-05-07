using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreKeeper : MonoBehaviour
{
    //[SerializeField] int score;


  [SerializeField] int score;
  const int DEFAULT_POINTS=10;
  [SerializeField] Text scoreTxt;
  [SerializeField] Text levelTxt;
  [SerializeField] Text nameTxt;
  [SerializeField] int level;
  [SerializeField] string name;




    // Start is called before the first frame update
    void Start()
    {
      name=PersistentData.Instance.GetName();
      //Debug.Log(name);

      score=PersistentData.Instance.GetScore();

      level =SceneManager.GetActiveScene().buildIndex;
      DisplayScore();
      DisplayLevel();
      DisplayName();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScore(int addend){

      score+=addend;
      DisplayScore();
      PersistentData.Instance.SetScore(score);

    }

    public void UpdateScore(){

      //UpdateScore(DEFAULT_POINTS);
    }
    public void DisplayScore(){

      scoreTxt.text="Score: " +score;
    }

    public void DisplayLevel(){

      int levelToDisplay= level;
      levelTxt.text="Level " +levelToDisplay;

    }
    public void DisplayName(){


      nameTxt.text=" Hi, " +name;
    }
}

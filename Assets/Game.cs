using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Game : MonoBehaviour
{
  [SerializeField] InputField playerNameInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayGame(){
    string s = playerNameInput.text;
    PersistentData.Instance.SetName(s);
	  SceneManager.LoadScene("Level1");
    }
    public void Instructions(){

	     SceneManager.LoadScene("Instruction");
    }
    public void MainMenu(){


	     SceneManager.LoadScene("Menu");
    }
    public void Setting(){
      SceneManager.LoadScene("Setting");
    }
}

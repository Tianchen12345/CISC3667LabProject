using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistent : MonoBehaviour
{
  [SerializeField] int playerScore;
  [SerializeField] string playerName;

  public static Persistent Instance;

  private void Awake()
  {
      if (Instance == null)
      {
          Instance=this;
          DontDestroyOnLoad(this);

      }
      else
      {
          Destroy(gameObject);
      }
  }
    // Start is called before the first frame update
    void Start()
    {
      playerScore = 0;
      playerName = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetName(string s)
    {
            playerName = s;
    }

    public void SetScore(int s)
    {
            playerScore = s;
    }

    public string GetName()
    {
          return playerName;
    }

    public int GetScore()
    {
          return playerScore;
    }


}

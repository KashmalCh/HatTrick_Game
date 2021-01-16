using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
    public static int Score;
    public static DataManager Instance;
    public static bool IsPlaying;
   
	// Use this for initialization
    void Awake()
    {
        Instance = this;
      DataManager.IsPlaying = false;
  
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeInScore(int value)
    {
       DataManager.Score += value;
        if(DataManager.Score <-4)
        {
            DataManager.IsPlaying = false;
          
        }
        print(Score);
   
    }
    public void StartGame()
    {
        DataManager.IsPlaying = true;
    }
   
}

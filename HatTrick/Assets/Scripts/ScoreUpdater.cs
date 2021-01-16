using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour {

    public  Text Score_Text;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Score_Text.text = "Score : " + DataManager.Score;
        if(DataManager.Score<=-5)
        {
            Score_Text.text = "";
        }
	}
 

}

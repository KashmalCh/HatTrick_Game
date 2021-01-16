using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
   public List<GameObject> Balls;
    public float LeftLimit;
    public float TopPosition;
    public float RightLimit;
    public float DelayOfTime;
    private bool FirstStart = true;
	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DataManager.IsPlaying == true&& FirstStart)
        {
            StartCoroutine("Pauser");
            FirstStart = false;
        }
       
		
	}
    IEnumerator Pauser()
    {
      
            while (true)
            {
                Generate();
                if (DataManager.IsPlaying == false)
                    break;
     
                yield return new WaitForSeconds(DelayOfTime);
            }
        
    }
    void Generate()
    {
        Vector3 NewPos = Vector3.zero;
        NewPos.x = Random.Range(LeftLimit,RightLimit);
        NewPos.y = TopPosition;
        Instantiate(Balls[Random.Range(0,Balls.Count)],NewPos,Quaternion.identity);
    }
}

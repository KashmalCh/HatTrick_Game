using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnCatch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "DestroyDepth")
        {
            if(this.gameObject.CompareTag("Bomb"))
            {
                other.gameObject.GetComponent<AudioSource>().Play();
                DataManager.Instance.ChangeInScore(-2);
                
              
            }
            else if (this.gameObject.CompareTag("SafeBall"))
            {  
                DataManager.Instance.ChangeInScore(+1);
                
            }
            
            Destroy(gameObject);
        }
      
    }
}

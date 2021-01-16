using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlHat : MonoBehaviour {

    public float HatSpeed;
    public float LeftLimit;
    public float RightLimit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.gameObject.SetActive(true);
        if (DataManager.IsPlaying == true )
        {
           
            if (Input.GetKey(KeyCode.LeftArrow) )
            {
                transform.position -= new Vector3(HatSpeed * Time.deltaTime, 0, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow) )
            {
                transform.position += new Vector3(HatSpeed * Time.deltaTime, 0, 0);
            }
            Vector3 MyPos = Vector3.zero;
            MyPos = transform.position;
            MyPos.x = Mathf.Clamp(MyPos.x, LeftLimit, RightLimit);
            transform.position = MyPos;
        }
        else
        {
            transform.gameObject.SetActive(false);
        }
      
	}
}

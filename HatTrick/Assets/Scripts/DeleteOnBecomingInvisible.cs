﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnBecomingInvisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

      
		
	}
  void OnBecameInvisible()
    {
      Destroy(transform.parent.gameObject);
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door : MonoBehaviour {
    [SerializeField] string sceneName;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        changeLevel();
    }

    private void changeLevel()
    {
        SceneManager.LoadScene(sceneName);
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string startLevel;
    

    public void NewGame()
    {
        SceneManager.LoadScene(0);
    }
    
	public void QuitGame()
    {
        Application.Quit();
    }
}

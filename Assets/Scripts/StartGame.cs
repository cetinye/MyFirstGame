﻿using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("Level01");
    }

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void WinGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoseGame()
    {
        SceneManager.LoadScene(3);
    }
}

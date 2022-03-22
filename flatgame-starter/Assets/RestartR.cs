﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartR : MonoBehaviour
{
    private void Update() {
        if(Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

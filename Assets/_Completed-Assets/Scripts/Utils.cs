using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Utils : MonoBehaviour {
    private static int currentLevel;
    private void Awake()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }
    // Update is called once per frame
    public static void LoadNextLevel () {
        SceneManager.LoadScene(currentLevel + 1);
        	}
    public static void reloadCurrentScene() {
        SceneManager.LoadScene(currentLevel);
    }
}

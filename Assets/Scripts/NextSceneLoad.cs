using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneLoad : MonoBehaviour
{
    public void NextScene(string x)
    {
        SceneManager.LoadScene(x);
        ScoreManager._score = 0;
    }
}

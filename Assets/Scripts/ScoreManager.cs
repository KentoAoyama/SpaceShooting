using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text _scoreText = default;
    public static int _score;

public void Score(int x)
    {
        _score += x;
    }


    void Update()
    {
        _scoreText.text = $"{_score}";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text _timerText = default;
    [SerializeField] Text _countDownText = default;
    public float _timer = 90;
    float _firstTimer;

    float _countdown = 3;
    public static bool _startGame;


    private void OnEnable()
    {
        if (_firstTimer == 0)
        {
            _firstTimer = _timer;
        }
        _countdown = 3;
        _timer = _firstTimer;
        _timerText.text = $"{_timer:f2}";
    }


    void FixedUpdate()
    {
        _countdown -= Time.deltaTime;

        if (_countdown < 0 && _timer > 0)
        {
            _startGame = true;
            _timer -= Time.deltaTime;
            _timerText.text = $"{_timer:f2}";
        }
        else if (_countdown >= 0)
        {
            _countDownText.text = $"{_countdown:f0}";
        }
        else if (_timer <= 0)
        {
            StartCoroutine(GameOver());
        }
    }

    void Update()
    {
        if (_countDownText.text == "0")
        {
            StartCoroutine(CountDown());
        }
    }

    IEnumerator CountDown()
    {
        _countDownText.text = "Start";
        yield return new WaitForSeconds(1f);
        _countDownText.text = "";
    }

    IEnumerator GameOver()
    {
        _startGame = false;
        _timerText.text = "Finish";
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("ResultScene");
    }
}

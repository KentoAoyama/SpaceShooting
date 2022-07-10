using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Text _timerText = default;
    [SerializeField] Text _countDownText = default;
    public float _timer = 90;

    float _countdown = 3;
    public static bool _startGame;


    private void OnEnable()
    {
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
            _timerText.text = "Finish";
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
}

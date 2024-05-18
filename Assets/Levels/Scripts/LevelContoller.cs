using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelContoller : Sound
{
    public static LevelContoller Instance;

    [SerializeField] private GameObject _panelWin;
    [SerializeField] private TMP_Text _textCoins;
    [SerializeField] private TMP_Text _textTime;
    [SerializeField] private string _suffixCoins;

    private CoinsHolder _coinsHolder;
    private int _countCoins;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void Start()
    {
        _coinsHolder = new CoinsHolder();
        _timerOn = true;
    }

    public void Win()
    {
        PlaySound(Sounds[0]);
        _timerOn = false;
        _coinsHolder.SetCoins(_coinsHolder.Coins + _countCoins);
        _panelWin.SetActive(true);

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        _textTime.text = string.Format("{0:00} : {1:00}", minutes, seconds);

        _textCoins.text = $"{_suffixCoins} {_countCoins}";
        CheckingRecord();
        _textTimer.gameObject.SetActive(false);
    }

    public void Lose()
    {
        SceneManager.LoadScene(Constants.Local.Scene.Gaming);
    }

    public void CollisionHole()
    {
        PlaySound(Sounds[1]);
    }

    public void Menu()
    {
        PlaySound(Sounds[2]);
        SceneManager.LoadScene(Constants.Local.Scene.Menu);
    }

    public void SetCoin(int count)
    {
        _countCoins += count;
    }

    private void CheckingRecord()
    {
        string id = Constants.Local.Save.RECORDTIME + PlayerPrefs.GetInt(Constants.Local.Save.CURRENTLEVEL);

        if (_timeLeft < PlayerPrefs.GetFloat(id) || PlayerPrefs.GetFloat(id) == 0) PlayerPrefs.SetFloat(id, _timeLeft);
    }

    #region Timer
    [SerializeField] private TMP_Text _textTimer;

    private float _timeLeft;
    private bool _timerOn;

    private void Update()
    {
        if (_timerOn)
        {
            _timeLeft += Time.deltaTime;
            UpdateTimeText();
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        _textTimer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    #endregion
}

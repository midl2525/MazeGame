using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecordItemView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textLevel;
    [SerializeField] private TMP_Text _textTime;

    [SerializeField] private string _suffixLevel;

    public void DisplayLevel(int level)
    {
        _textLevel.text = $"{_suffixLevel} {level}";
    }

    public void DisplayTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        _textTime.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Records : MonoBehaviour
{
    [SerializeField] private RecordsView _recordsView;

    private List<RecordConfig> _recordConfigs = new List<RecordConfig>();

    private void Start()
    {
        LoadList();
        _recordsView.DisplayRecordItems(_recordConfigs);
    }
     


    private void LoadList()
    {
        _recordConfigs.Clear();

        for (int i = 0; i < 8; i++)
        {
            RecordConfig recordConfig = new RecordConfig();
            recordConfig.Level = i + 1;
            recordConfig.Time = PlayerPrefs.GetFloat(Constants.Local.Save.RECORDTIME + i);

            _recordConfigs.Add(recordConfig);
        }
    }

    private void SaveListRecords()
    {
        for (int i = 0; i < _recordConfigs.Count; i++)
        {
            RecordConfig _currentRecordonfig = _recordConfigs[i];;
            PlayerPrefs.SetFloat(Constants.Local.Save.RECORDTIME + i, _currentRecordonfig.Time);
        }

        PlayerPrefs.Save();
    }
}

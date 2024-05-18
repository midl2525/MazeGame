using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordsView : IMenuPanel
{
    [SerializeField] private RecordItemView[] _recordItems;

    public void DisplayRecordItems(List<RecordConfig> recordConfigs)
    {
        for (int i = 0; i < _recordItems.Length; i++)
        {
            RecordItemView _currentRecordItem = _recordItems[i];
            RecordConfig _currentRecordConfig = recordConfigs[i];

            _currentRecordItem.DisplayLevel(_currentRecordConfig.Level);
            _currentRecordItem.DisplayTime(_currentRecordConfig.Time);
        }
    }

    public override void Close()
    {
        gameObject.SetActive(false);
    }

    public override void Open()
    {
        gameObject.SetActive(true);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public static Bootstrap Instance { get; private set; }

    public bool IsFirstStart { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else Destroy(gameObject);
    }

    private void Start()
    {
        Load();
    }

    private void Load()
    {
        if (PlayerPrefs.GetInt(Constants.Local.Save.FIRSTSTART) > 0)
        {
            IsFirstStart = false;
        }
        else
        {
            IsFirstStart = true;
            Save();
        }
    }
    private void Save()
    {
        PlayerPrefs.SetInt(Constants.Local.Save.FIRSTSTART, 1);
        PlayerPrefs.Save();
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsView : IMenuPanel
{

    public void LoadLevelScene(int level)
    {
        PlayerPrefs.SetInt(Constants.Local.Save.CURRENTLEVEL, level);
        PlayerPrefs.Save();
        SceneManager.LoadScene(Constants.Local.Scene.Gaming);
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
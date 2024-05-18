using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;
    [SerializeField] private Transform _ball;

    private void Start()
    {
        Loaded();
    }

    public void Loaded()
    {
        int currentLevel = PlayerPrefs.GetInt(Constants.Local.Save.CURRENTLEVEL);
        LevelConfig levelConfig = _levelData.LevelConfig[currentLevel];
        Instantiate(levelConfig.PrefabLevel);
        _ball.localScale = new Vector2(levelConfig.BallSize, levelConfig.BallSize);
        _ball.position = levelConfig.StartPosition;
        LevelContoller.Instance.SetCoin(levelConfig.Profit);
    }
}

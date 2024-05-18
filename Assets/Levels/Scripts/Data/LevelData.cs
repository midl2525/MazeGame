using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/Level Data")]
public class LevelData : ScriptableObject
{
    public List<LevelConfig> LevelConfig => _levelConfig;

    [SerializeField] private List<LevelConfig> _levelConfig;
}

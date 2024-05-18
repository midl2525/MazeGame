using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/Skins Data")]
public class SkinsData : ScriptableObject
{
    public List<SkinConfig> SkinConfigs => _skinConfigs;

    [SerializeField] private List<SkinConfig> _skinConfigs;  
}

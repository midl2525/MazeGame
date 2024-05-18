using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelsSwitcher : Sound
{
    [SerializeField] private IMenuPanel _panelMenu;
    [SerializeField] private List<IMenuPanel> _panels;

    private void Start()
    {
        OpenPanel(_panelMenu);
    }

    public void OpenPanel(IMenuPanel panel)
    {
        PlaySound(Sounds[0]);
        CloseAllPanels();
        panel.Open();
    }

    private void CloseAllPanels()
    {
        foreach (var item in _panels)
        {
            item.Close();
        }
    }
}

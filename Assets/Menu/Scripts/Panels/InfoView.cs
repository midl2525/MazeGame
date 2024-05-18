using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoView : IMenuPanel
{
    public override void Close()
    {
        gameObject.SetActive(false);
    }

    public override void Open()
    {
        gameObject.SetActive(true);

    }
}

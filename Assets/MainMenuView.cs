using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] Text _titletext;

    public void Setup(string title) {
        _titletext.text = title;
    }
}

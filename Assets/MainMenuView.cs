using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] Text _titletext;
    
    [SerializeField] Transform _buttonsList;
    [SerializeField] ButtonView _buttonViewPrefab;

    public void Setup(string title) {
        _titletext.text = title;
    }

    public void AddButton(Action buttonCallback, string labelText) {
        ButtonView buttonview = Instantiate(_buttonViewPrefab, _buttonsList);
        buttonview.Setup(buttonCallback, labelText);
    }
}

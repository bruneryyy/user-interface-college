using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : View
{
    Action _buttonCallback;
    [SerializeField] Text _labelText;

    public void Setup(Action buttonCallback, string labelText) {
        _buttonCallback = buttonCallback;
        _labelText.text = labelText;

    }

    public void OnClick (){
        if (_buttonCallback != null) {
            _buttonCallback.Invoke();
        }
    }
}

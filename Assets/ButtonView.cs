using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    Action _buttonCallback;
    [SerializeField] Text _labelText;

    void Setup(Action buttonCallback, string labelText) {
        _buttonCallback = buttonCallback;
        _labelText.text = labelText;

    }

    public void OnClick (){
        if (_buttonCallback != null) {
            _buttonCallback.Invoke();
        }
    }
}

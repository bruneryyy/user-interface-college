using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuView : View
{
   [SerializeField] Text _titleText;
   [SerializeField] ButtonView _buttonView;
    
   public void Setup(Action buttonCallback, string labelText, string titleText) {
        _titleText.text = titleText;
       _buttonView.Setup(buttonCallback, labelText);
   }
}

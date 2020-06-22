using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorViewControllerFactory : MonoBehaviour, IViewControllerFactory
{
    [SerializeField]  SceneWireframe _wireframe;

    [SerializeField] MainMenuView _mainMenuMenuViewPrefab;
    [SerializeField] SettingsMenuView _settingsMenuViewPrefab;

    public MainMenuViewController CreateMainMenuViewController() {
        MainMenuView mainMenuView = Instantiate(_mainMenuMenuViewPrefab);
        return new MainMenuViewController (mainMenuView, _wireframe, this);

    }
    
    public SettingsMenuViewController CreateSettingsMenuViewController() {
      SettingsMenuView settingsMenuView = Instantiate(_settingsMenuViewPrefab);
        return new SettingsMenuViewController (settingsMenuView, _wireframe, this);  
    }

}

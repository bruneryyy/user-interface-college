using UnityEngine;

public class InspectorViewControllerFactory : MonoBehaviour, IViewControllerFactory
{
    [SerializeField]  SceneWireframe _wireframe;

    [SerializeField] MainMenuView _mainMenuMenuViewPrefab;

    public MainMenuViewController CreateMainMenuViewController() {
        MainMenuView mainMenuView = Instantiate(_mainMenuMenuViewPrefab);
        return new MainMenuViewController (mainMenuView, _wireframe, this);
    }

}

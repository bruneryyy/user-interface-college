using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuViewController : ViewController<MainMenuView>
{
   SceneWireframe _wireframe;
   IViewControllerFactory _factory;

   public MainMenuViewController(MainMenuView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view){
       _wireframe = wireframe;
       _factory = factory;
   }

  public void Setup() {
       View.Setup(Application.productName);

       View.AddButton(PlayGame, "Play");
       View.AddButton(ShowSettingsMenu, "Settings");
       View.AddButton(QuitGame, "Quit");
   }

   void PlayGame () {

   }
   
   void ShowSettingsMenu() {
       SettingsMenuViewController viewController = _factory.CreateSettingsMenuViewController();
       viewController.Setup();

       _wireframe.PresentViewController(viewController);

   }
   void QuitGame() {

   }
}

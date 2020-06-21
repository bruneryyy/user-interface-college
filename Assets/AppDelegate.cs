using System.Collections;
using UnityEngine;

public class AppDelegate : MonoBehaviour
{
    [SerializeField] private SceneWireframe _wireframe;


    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        Init();
    }
    private void Init()
    {
        new GameInitializer(_wireframe).Init();
    }

}
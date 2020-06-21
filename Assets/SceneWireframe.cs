using UnityEngine; 

    public class SceneWireframe : MonoBehaviour
{
[SerializeField] private Transform _holder;


 public void PresentView(View View)
{

     foreach (Transform child in _holder){
         Destroy(child.gameObject);
     }

     view.transform.SetParent(_holder, false);
  } 

}

#if UNITY_EDITOR
using UnityEditor;

using UnityEngine;
using System.Collections;
/// <summary>
/// Esta clase no pertenece al cualquier proyecto en el cual se encuentre presente, es una funcionalidad del motor en si, mas no del proyecto en el que se encuentre, por lo cual no es propiedad del proyecto. 
/// es propiedad de Rodrigo Porras M. 
/// </summary>
public class UGUIMenu : MonoBehaviour{

	[MenuItem ("UI/Anchor Around Object")]

	static void uGUIAnchorAroundObject(){

		//var o = Selection.activeGameObject;
		GameObject[] array = Selection.gameObjects;

		foreach (var item in array) {
			if (item != null && item.GetComponent<RectTransform>() != null){
				
				var r = item.GetComponent<RectTransform>();
				var p = item.transform.parent.GetComponent<RectTransform>();
				
				var offsetMin = r.offsetMin;
				var offsetMax = r.offsetMax;
				var _anchorMin = r.anchorMin;
				var _anchorMax = r.anchorMax;
				
				var parent_width = p.rect.width;      
				var parent_height = p.rect.height;  
				
				var anchorMin = new Vector2(_anchorMin.x + (offsetMin.x / parent_width),
				                            _anchorMin.y + (offsetMin.y / parent_height));
				var anchorMax = new Vector2(_anchorMax.x + (offsetMax.x / parent_width),
				                            _anchorMax.y + (offsetMax.y / parent_height));
				
				r.anchorMin = anchorMin;
				r.anchorMax = anchorMax;
				
				r.offsetMin = new Vector2(0, 0);
				r.offsetMax = new Vector2(0, 0);
				r.pivot = new Vector2(0.5f, 0.5f);
				
			}
		}


	}
}
#endif
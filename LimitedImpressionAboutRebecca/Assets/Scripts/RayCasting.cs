using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 using System.Collections.Generic;
 
 public class RayCasting : MonoBehaviour, IPointerClickHandler
 {
     public GraphicRaycaster targetCanvas;
     private RectTransform thisRect;
     void Start()
     {
         thisRect = GetComponent<RectTransform>();//store this object's RectTransform for later
     }
 
     public void OnPointerClick(PointerEventData eventData)
     {
         Vector2 localCursor;
         if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(thisRect, eventData.position, eventData.pressEventCamera, out localCursor)) //just in case this gets triggered somehow without actually clicking on image
             Debug.Log("Did not click inside the Image");
         else
         {
             localCursor += new Vector2(thisRect.rect.width * thisRect.pivot.x, thisRect.rect.height * thisRect.pivot.y);//current image is centered, this offsets it by the midpoint so that the localCursor value is 0,0 at bottom left and image's width/height at top right
             RectTransform targetCanvasRect = targetCanvas.GetComponent<RectTransform>();//get the transform of target canvas for next step
             localCursor = localCursor * (targetCanvasRect.sizeDelta / thisRect.sizeDelta);//translate cursor position into position relative to canvas, so 0,0 is still bottom left but top right is now canvas width/height
             List<RaycastResult> results = new List<RaycastResult>(); //create list to hold raycast hits
             eventData.position = localCursor;//replace eventdata's position with our new updated position
             targetCanvas.Raycast(eventData, results);//do raycast to target canvas
 
             foreach (RaycastResult result in results)
             {
                 Debug.Log("Hit " + result.gameObject.name);
                 Button targetButton = result.gameObject.GetComponent<Button>(); //get button component of hit object
                 if (targetButton != null)//make sure it hit a button
                     targetButton.onClick.Invoke();//click button
             }
 
         }
     }
 }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D hoverCursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PointEnter(Texture2D cursorTexture)
        {

            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        }
    public void Clicked(Texture2D cursorTexture){
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}

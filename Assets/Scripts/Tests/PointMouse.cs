using UnityEngine;
using System.Collections;

public class PointMouse : MonoBehaviour {

    public Texture2D crosshairTexture;
    private int mouseCursorWidth = 32;
    private int mouseCursorHeight = 32;
    private Transform mouseTransform;
    private Camera sceneCamera;


    // Use this for initialization
    void Start () {
        sceneCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        mouseTransform = transform;
        
    }

    void OnGUI(){
        Screen.lockCursor = true;
        Vector3 screenPosition = sceneCamera.WorldToScreenPoint(mouseTransform.position);

        screenPosition.y = Screen.height - screenPosition.y;

        GUI.DrawTexture(new Rect(screenPosition.x, screenPosition.y, mouseCursorWidth, mouseCursorHeight), crosshairTexture);
    }
	
	
}

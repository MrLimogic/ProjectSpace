using UnityEngine;
using System.Collections;

public class CrossHairGUI : MonoBehaviour {

    public Texture2D CrossHair;

    //void OnGUI()
    //{
    //    GUI.Label(new Rect(Screen.width / 2 - 16, Screen.height / 2 - 16, 32, 32), CrossHair);
    //}

    //void OnGUI()
    //{
    //    float xMin = (Screen.width - Input.mousePosition.x) - (CrossHair.width / 2);
    //    float yMin = (Screen.height - Input.mousePosition.y) - (CrossHair.height / 2);
    //    GUI.DrawTexture(new Rect(xMin, yMin, CrossHair.width, CrossHair.height), CrossHair);
    //}

    public Rect position;
    static bool OriginalOn = true;

    void start() {
        position = new Rect((Screen.width - CrossHair.width) / 2, (Screen.height - CrossHair.height) / 2, CrossHair.width, CrossHair.height);
    }

    void OnGUI() {
        Screen.lockCursor = true;
        //Screen.showCursor = false;
        if(OriginalOn == true)
        {
            GUI.DrawTexture(position, CrossHair);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    void Awake()
    {
        Camera camera = GetComponent<Camera>();
        Rect rect = camera.rect;
        
        float scaleHeight = ((float) Screen.width / Screen.height) / ((float) 9 / 16);
        float scaleWidth = ((float) 3 / 4) / ((float) Screen.width / Screen.height);

        if (scaleHeight < 1) {
            rect.height = scaleHeight;
            rect.y = (1f - scaleHeight) / 2f;
        }
        else if (scaleWidth < 1) {
            rect.width = scaleWidth;
            rect.x = (1f - scaleWidth) / 2f;
        }

        camera.rect = rect;
    }

    void OnPreCull() => GL.Clear(true, true, Color.black);
}

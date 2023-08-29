#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class ScreenshotGrabber
{
    [MenuItem("Screenshot/Grab")]
    public static void Grab()
    {

        ScreenCapture.CaptureScreenshot("C:/Users/fabio/Desktop/Screenshot" + Mathf.Round(Random.Range(1, 500)) + ".png", 1);
        
    }
}
#endif
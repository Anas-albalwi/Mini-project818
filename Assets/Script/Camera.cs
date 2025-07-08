using UnityEngine;

public class FullscreenManager : MonoBehaviour
{
    void Start()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true);
    }
}

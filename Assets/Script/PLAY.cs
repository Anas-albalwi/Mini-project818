using UnityEngine;
using UnityEngine.SceneManagement;
public class PLAY : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Quitgame()
    {
        Application.Quit();
    }

}

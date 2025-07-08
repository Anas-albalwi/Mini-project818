using UnityEngine;
using UnityEngine.SceneManagement;
public class Gameover : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
}

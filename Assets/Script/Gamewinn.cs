using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamewinn : MonoBehaviour
{
    public GameObject objectA;
    public GameObject objectB;

    private bool aInTrigger = false;
    private bool bInTrigger = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == objectA)
            aInTrigger = true;

        if (other.gameObject == objectB)
            bInTrigger = true;

        CheckBothEntered();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == objectA)
            aInTrigger = false;

        if (other.gameObject == objectB)
            bInTrigger = false;
    }

    void CheckBothEntered()
    {
        if (aInTrigger && bInTrigger)
        {
            Debug.Log("Both objects are inside. Loading scene...");
            SceneManager.LoadScene(3);
        }
    }
}

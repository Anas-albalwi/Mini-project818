using UnityEngine;
using UnityEngine.Audio;

public class Cion : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject,0.7f);
            audioSource.Play();
        }
    }
}

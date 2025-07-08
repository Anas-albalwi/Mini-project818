using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float Jumpforce;
    [SerializeField] Transform Groundpoint;
    [SerializeField] private float grounradius;
    [SerializeField] private LayerMask layerGround;
    Vector2 startPos;
    private Rigidbody2D rb;
    private float moveXinput;
    private bool isGrouunded;
    private int lives = 1;
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrouunded = Physics2D.OverlapCircle(Groundpoint.position, grounradius, layerGround);

        moveXinput = Input.GetAxisRaw("Horizontal2");
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrouunded == true)
        {


            rb.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
        }

    }
    void FixedUpdate()
    {
        rb.linearVelocityX = moveXinput * moveSpeed;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(Groundpoint.position, grounradius);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("Respon"))
        {
            Die();
            lives--;
            if (lives <= 0)
            {
                SceneManager.LoadSceneAsync(2);
            }

        }
    }

    void Die()
    {
        Respawn();
    }

    void Respawn()
    {
        transform.position = startPos;
    }
}

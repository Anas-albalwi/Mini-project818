using UnityEngine;

public class Rope : MonoBehaviour
{
    public GameObject Frogy_P1;
    public GameObject Frogy_P2;
    private LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lineRenderer.SetPosition(0, Frogy_P1.transform.position);
        lineRenderer.SetPosition(1, Frogy_P2.transform.position);

    }
}

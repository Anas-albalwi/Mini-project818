using UnityEngine;

public class jointDes : MonoBehaviour
{
    public GameObject Frogy_P1;
    public GameObject Frogy_P2;
    private SpringJoint2D springJoint;

    void Start()
    {
        springJoint = GetComponent<SpringJoint2D>();

        springJoint.connectedBody = Frogy_P2.GetComponent<Rigidbody2D>();
        springJoint.distance = 5f;  
        springJoint.frequency = 5f; 
        springJoint.dampingRatio = 0.5f; 
    }
}

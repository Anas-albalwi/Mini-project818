using UnityEngine;

public class RopeSimulator : MonoBehaviour
{
    public GameObject player1;   // الطرف الأول من الحبل
    public GameObject player2;   // الطرف الثاني من الحبل

    private SpringJoint2D springJoint1;
    private SpringJoint2D springJoint2;

    public float springForce = 100f;     // قوة الربيع
    public float damper = 2f;           // التخميد
    public float minDistance = 2f;      // المسافة الدنيا بين الطرفين
    public float maxDistance = 5f;      // المسافة القصوى بين الطرفين

    void Start()
    {
        // إضافة Spring Joint 2D للطرف الأول (player1)
        springJoint1 = player1.AddComponent<SpringJoint2D>();
        springJoint1.connectedBody = player2.GetComponent<Rigidbody2D>();   // ربط اللاعب الأول بالثاني
        springJoint1.dampingRatio = damper;
        springJoint1.frequency = springForce;
        springJoint1.distance = minDistance;  // تحديد المسافة الدنيا

        // إضافة Spring Joint 2D للطرف الثاني (player2)
        springJoint2 = player2.AddComponent<SpringJoint2D>();
        springJoint2.connectedBody = player1.GetComponent<Rigidbody2D>();  // ربط اللاعب الثاني بالأول
        springJoint2.dampingRatio = damper;
        springJoint2.frequency = springForce;
        springJoint2.distance = minDistance;  // تحديد المسافة الدنيا
    }

    void Update()
    {
        // محاكاة تأثير المسافة بين الطرفين (الحبل) 
        float distanceBetweenPlayers = Vector2.Distance(player1.transform.position, player2.transform.position);

        // إذا كانت المسافة بين الطرفين أكبر من الحد الأقصى، نضبط المسافة
        if (distanceBetweenPlayers > maxDistance)
        {
            springJoint1.distance = maxDistance;  // تأكد من أن الحبل لا يمتد أكثر من اللازم
            springJoint2.distance = maxDistance;
        }
        else
        {
            springJoint1.distance = minDistance;  // الحبل يجب أن يعود إلى المسافة الدنيا
            springJoint2.distance = minDistance;
        }
    }
}

using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform FrogyP1;            
    public Transform FrogyP2;

    public TargetJoint2D targetJointFrogy1;         
    public TargetJoint2D targetJointFrogy2;

    public Rigidbody2D FrogyRb1;                  
    public Rigidbody2D FrogyRb2;
    public float fallSpeedThreshold = -9.5f;   
    private bool isFalling = false;

    void Update()
    {
        if (FrogyRb1.linearVelocity.y <= fallSpeedThreshold && !isFalling)
        {
            isFalling = true;

            if (targetJointFrogy2 != null && FrogyP1 != null)
            {
                targetJointFrogy2.enabled = true;
                targetJointFrogy2.target = FrogyP1.position;


                Invoke(nameof(DisTarget2), 0.1f);


            }
        }

        if (FrogyRb1.linearVelocity.y > fallSpeedThreshold && isFalling)
        {
            isFalling = false;
            targetJointFrogy2.enabled = false;
            
        }


        if (FrogyRb2.linearVelocity.y <= fallSpeedThreshold && !isFalling)
        {
            isFalling = true;

            if (targetJointFrogy1 != null && FrogyP2 != null)
            {
                targetJointFrogy1.enabled = true;
                targetJointFrogy1.target = FrogyP2.position;


                Invoke(nameof(DisTarget), 0.1f);
            }
        }

        if (FrogyRb2.linearVelocity.y > fallSpeedThreshold && isFalling)
        {
            isFalling = false;
            targetJointFrogy1.enabled = false;

        }
    }

    void DisTarget()
    {
        if (targetJointFrogy1 != null)
        {
            targetJointFrogy1.enabled = false;
        }

    }
    void DisTarget2()
    {
        if (targetJointFrogy2 != null)
        {
            targetJointFrogy2.enabled = false;
        }

    }
}

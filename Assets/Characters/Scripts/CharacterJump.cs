using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    protected float jumpImpulse = 20f;
    protected Vector2 jumpDirection = Vector2.up;
    protected Rigidbody2D controlledRigidBody;

    public void Jump()
    {
        controlledRigidBody.AddForce(jumpDirection * jumpImpulse, ForceMode2D.Impulse);
    }

}

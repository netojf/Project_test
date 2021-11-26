using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] Transform controlledTransform;
    [SerializeField] Vector2 moveDirection = Vector2.zero;
    [SerializeField, Range(0f, 10f)] float moveSpeed = 2f;


    public void WalkInputReceived(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }


    private void FixedUpdate()
    {

        controlledTransform.position += (Vector3)(moveDirection * moveSpeed * Time.fixedDeltaTime);

    }

}
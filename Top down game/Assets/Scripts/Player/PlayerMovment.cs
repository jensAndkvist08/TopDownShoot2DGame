using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 moveInput;
    Vector2 screenBoundary;
    [SerializeField] float moveSpeed = 70f;
    [SerializeField] float rotateSpeed = 2000f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }
    
    void Update()
    {
        rb.velocity = moveInput * moveSpeed;

        if (moveInput != Vector2.zero)
        {
            Quaternion targetRotaion = Quaternion.LookRotation(transform.forward, moveInput);
            Quaternion rotate = Quaternion.RotateTowards(transform.rotation, targetRotaion, rotateSpeed * Time.deltaTime);

            rb.MoveRotation(rotate);
        }
        else
        {
            rb.angularVelocity = 0;
        }

        screenBoundary = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        transform.position = new Vector2(math.clamp(transform.position.x, -screenBoundary.x, screenBoundary.x), math.clamp(transform.position.y, -screenBoundary.y, screenBoundary.y));
    }
}

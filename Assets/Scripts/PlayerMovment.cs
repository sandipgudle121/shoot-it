using System;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float controlSpeed = 50.0f;
    [SerializeField] float xClampRange = 10.0f;
    [SerializeField] float yClampRange = 10.0f;

    [SerializeField] float controlRollFactor = 20.0f;

    [SerializeField] float controlPitchFactor = 20.0f;
    [SerializeField] float rotationSpeed = 10.0f;
    Vector2 movement;
    void Update()
    {
        processTranslation();
        processRotation();
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();        
    }
    void processTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xClampRange, xClampRange);
        float clampedYPos = Mathf.Clamp(rawYPos, -yClampRange, yClampRange);
        transform.localPosition = new Vector3(clampedXPos, clampedYPos, 0.0f);
    }
    void processRotation()
    {
        float roll = -controlRollFactor * movement.x;
        float pitch = -controlPitchFactor * movement.y;
        Quaternion targetRotation = Quaternion.Euler(pitch, 0.0f, roll);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}

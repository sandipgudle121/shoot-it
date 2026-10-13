using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crossHair;
    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance = 100.0f;
    bool isFiring = false;

    void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        processFiring();
        moveCrosshair();
        moveTargetPoint();
        aimLasers();
    }
    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void processFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
    }

    void moveCrosshair()
    {
        crossHair.position = Mouse.current.position.ReadValue();
    }

    void moveTargetPoint()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Vector3 targetPointPosition = new Vector3(mousePosition.x, mousePosition.y, targetDistance);
        targetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition); 
    }

    void aimLasers()
    {
        foreach (GameObject laser in lasers)
        {
            Vector3 fireDirection = targetPoint.position - this.transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(fireDirection);
            laser.transform.rotation = rotationToTarget;
        }
    }
}

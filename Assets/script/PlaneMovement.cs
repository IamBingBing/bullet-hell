using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private Joystick joystick;

    private Vector3 _startPosition;

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector2 input = new Vector2(joystick.Horizontal, joystick.Vertical);

        
        if (input.sqrMagnitude > 0.01f)
        {
            Vector3 movement = new Vector3(input.x, input.y, 0f) * moveSpeed * Time.deltaTime;
            transform.position += movement;
        }

        ClampPosition();
    }

    private void ClampPosition()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -20f, 20f);
        pos.y = Mathf.Clamp(pos.y, -20f, 20f);
        

        transform.position = pos;
    }
}




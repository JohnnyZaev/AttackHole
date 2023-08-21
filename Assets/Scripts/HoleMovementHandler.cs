using UnityEngine;

public class HoleMovementHandler : MonoBehaviour
{
    [SerializeField] private Joystick joyStick;
    [SerializeField] private float speed = 5f;
    private Vector3 _direction;

    private void Update()
    {
        _direction.x = joyStick.Direction.x;
        _direction.z = joyStick.Direction.y;
        transform.Translate(_direction * (Time.deltaTime * speed));
    }
}

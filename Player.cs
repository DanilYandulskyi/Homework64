using UnityEngine;

[RequireComponent(typeof(CharacterControllerMover))]
public class Player : MonoBehaviour
{
    private CharacterControllerMover _mover;

    private void Awake()
    {
        _mover = GetComponent<CharacterControllerMover>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw(Axis.Horizontal);
        float vertical = Input.GetAxisRaw(Axis.Vertical);

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        if (Input.GetKey(KeyCode.Space))
        {
            direction += Vector3.down;
        }

        _mover.Move(direction);
    }
}

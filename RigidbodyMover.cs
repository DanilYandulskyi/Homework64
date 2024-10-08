using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyMover : Mover
{
    private Rigidbody _rigidbody;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();   
    }

    public override void Move(Vector3 direction)
    {
        Vector3 offset = direction.normalized * (Speed * Time.deltaTime);
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }
}

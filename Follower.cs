using UnityEngine;

[RequireComponent(typeof(RigidbodyMover))]
public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    private RigidbodyMover _mover;
    private float _minDistance = 2;

    private void Awake()
    {
        _mover = GetComponent<RigidbodyMover>();
    }

    private void Update()
    {
        Vector3 direction = (_target.position - transform.position).normalized;

        if (Vector3.Distance(_target.position, transform.position) <= _minDistance)
            return;

        _mover.Move(direction);
    }
}

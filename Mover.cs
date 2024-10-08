using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected float Speed => _speed;

    public abstract void Move(Vector3 direction);
}

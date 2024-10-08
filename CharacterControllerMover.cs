using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(SurfaceSlider))]
public class CharacterControllerMover : Mover
{
    private CharacterController _characterController;
    private SurfaceSlider _slider;

    private void Awake()
    {
        _slider = GetComponent<SurfaceSlider>();
        _characterController = GetComponent<CharacterController>();
    }

    public override void Move(Vector3 direction)
    {
        Vector3 offset = _slider.Project(direction.normalized) * (Speed * Time.deltaTime);

        _characterController.Move(offset);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    private Shooter2D shooter;
    private LifeBehaviour life;

    private void Awake()
    {
        shooter = GetComponent<Shooter2D>();
        life = GetComponent<LifeBehaviour>();
    }

    private void Start()
    {
        GetComponentInParent<PlayerInput>().SwitchCurrentActionMap("Player2");
    }

    private void OnFire()
    {
        shooter.Shoot();
    }
}

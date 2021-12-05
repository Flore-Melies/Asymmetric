using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private Shooter2D shooter;

    // Start is called before the first frame update
    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, 0.4f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}

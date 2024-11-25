using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector2 direction = Player.transform.position - transform.position;

        _rigidbody2D.velocity = direction.normalized  * _speed;
    }
}

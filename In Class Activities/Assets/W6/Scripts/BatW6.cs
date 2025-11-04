using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
   
    [SerializeField] private float _speed;
    private Transform _playerTransform;
 

    public void StopChasing()
    {
        enabled = false;
    }

    public void StartChasing(Transform player)
    {
        // transform.Translate(Vector3(transform.position.x * _speed, transform.position.y * _speed, 0.0f)*_playerPosition.normalized);
        // transform.Translate(_playerPosition.normalized * _speed*Time.deltaTime);
        enabled = true;
        _playerTransform = player;

    }

    private void Start()
    {
        enabled = false;
    }

    private void Update()
    {
        if (enabled)
        {
            transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
        }
    }
}

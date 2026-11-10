using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    private Transform _target;
    private bool _isChasing;

    private void Update() {
        if (!_isChasing || _target == null) {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
    public void StartChasing(Transform playerTransform) {
        _target = playerTransform;
        _isChasing = true;
    }
    public void StopChasing() {
        _isChasing = false;
    }
}

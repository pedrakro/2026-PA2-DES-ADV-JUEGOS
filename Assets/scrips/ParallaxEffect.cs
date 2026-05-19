using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public GameObject cam;
    public float parallaxEffect;
    
    private float _startPosition;
    private float _length;

    private void Awake()
    {
        _length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    private void Start()
    {
        _startPosition = transform.position.x;
    }

    private void LateUpdate()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        float movement = cam.transform.position.x * (1 - parallaxEffect);
        transform.position = new Vector3(_startPosition + distance,
            transform.position.y, 
            transform.position.z);

        if (movement > _startPosition + _length) _startPosition += _length;
        else if (movement < _startPosition - _length) _startPosition -= _length;
    }
}

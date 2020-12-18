using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1.4f;
    private float _rotationTimer = 0;
    private float _rotationSpeed = 50;
    private float _startAngle = 15f;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rotationTimer = 0;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {
            _rotationTimer += Time.deltaTime * _rotationSpeed;
            if (Input.GetMouseButtonDown(0))
            {
                _rb.velocity = Vector2.up * velocity;
                _rotationTimer = -_startAngle;
            }
            _rb.transform.rotation = Quaternion.Euler(Vector3.forward * velocity * -_rotationTimer);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }
}

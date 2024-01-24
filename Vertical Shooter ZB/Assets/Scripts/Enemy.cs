using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float respawnY = 10f;

    private float _respawnX;

    private Rigidbody2D _RigidBody2D;

    private void Awake()
    {
        _RigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _respawnX = transform.position.x;
    }

    
    public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(_respawnX, respawnY);
        _RigidBody2D.velocity = Vector2.zero;
    }

    private void OnMouseDown()
    {
        Debug.Log("down");
        gameObject.SetActive(false);
        GameManager.instance.UnListEnemy(gameObject);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private float respawnY = 10f;

    public Health health;

    private Enemy enemy;

    private Health playerHealth;
    
    private float _respawnX;

    private Rigidbody2D _RigidBody2D;

    private void Awake()
    {
        _RigidBody2D = GetComponent<Rigidbody2D>();
        playerHealth = GetComponent<Health>();

    }
    // Start is called before the first frame update
    void Start()
    {
        _respawnX = transform.position.x;
    }

    //Enemy Respawns
    public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(_respawnX, respawnY);
        _RigidBody2D.velocity = Vector2.zero;
    }

    private void OnMouseDown()
    {
        Debug.Log("down");
     
    }

    //Enemy Enters a Trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Laser hits Enemy and the enemy despawns
        if (other.gameObject.tag == "Laser")
        {
            Despawn();
        }
        //Player takes Damage from colliding with the enemy
        else if (other.gameObject.tag == "Player")
        {
        
            health.TakeDamage(5);
            Debug.Log(health.startingHealth);
        }
    }

    //Enemy Despawns
    private void Despawn()
    {
        gameObject.SetActive(false);
        GameManager.instance.UnListEnemy(gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
    
    
}
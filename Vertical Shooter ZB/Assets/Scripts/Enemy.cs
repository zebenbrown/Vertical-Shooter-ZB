using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
    //[SerializeField] private float respawnY = 10f;

    public Health health;

    private Enemy enemy;

    private Health playerHealth;

    public Score score;
    
    private float _respawnX;

    private Rigidbody2D _RigidBody2D;
    private bool addToScore;

    private void Awake()
    {
        _RigidBody2D = GetComponent<Rigidbody2D>();
        playerHealth = GetComponent<Health>();

    }
    // Start is called before the first frame update
    void Start()
    {
        //_respawnX = transform.position.x;

        if (tag == "Enemy")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0.0f, -5.0f);
        }
    }

    //Enemy Respawns
   /* public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(_respawnX, respawnY);
        _RigidBody2D.velocity = Vector2.zero;
    }*/

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
            RepositionEnemy(true);
        }
        //Player takes Damage from colliding with the enemy
        else if (other.gameObject.tag == "Player")
        {

            health.TakeDamage(5);
        }

        else if(other.gameObject.tag == "Barrier")
        {
            RepositionEnemy(false);
        }
    }

    //Enemy Despawns
    private void Despawn()
    {
        gameObject.SetActive(false);
        GameManager.instance.UnListEnemy(gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        
    }
    public void RepositionEnemy(bool addToScore)
    {
        Debug.Log("Respawn");
        
        

        gameObject.SetActive(true);
        float newX = Random.Range(-9, 9);
        float newY = Random.Range(31, 31);
        Debug.Log("NewX = " + newX);
        Vector2 newpos = new Vector2(newX, newY);
        transform.position = newpos;

        if (tag == "Enemy")
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0.0f, -5.0f);
            
        }

        else if (tag == "Player")
        {
            health.TakeDamage(5);
            Debug.Log(health.startingHealth);
        }
        if (addToScore == true)
        {
            score.addScore(1);
        }
    }
    
}
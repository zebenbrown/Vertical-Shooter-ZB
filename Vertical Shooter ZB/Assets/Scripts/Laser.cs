using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour

{
    //public Health health;
    //var HealthComponent;

    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 1f;
    private float _life = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        _life += Time.deltaTime;
        if (_life >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

   
    //Working on Damage Function
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
             HealthComponent = HealthComponent.GetComponent<Health>();
            health.TakeDamage(5);

        }
    }*/
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 30f;
    //[SerializeField] float lifetime = 5f; // Bullet lifetime in seconds

    private Vector2 direction;
    private int hitCount = 0;
    private Gun gun;

    public int ricochetInt = 3;
    public GameObject target;

    void Awake()
    {
        // Eliminate the effect of gravity on the bullet
        rb.gravityScale = 0;
        target = GameObject.Find("Character");
    }

    public void Shoot(Vector2 direction, Gun gun)
    {
        this.direction = direction.normalized;
        this.gun = gun;
        rb.velocity = this.direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        hitCount++;
        if (hitCount == ricochetInt)
        {
            StartCoroutine(DestroyBulletAfterDelay(0.05f));
        }


        // Reflect the bullet's direction when it hits something
        Vector2 normal = collision.contacts[0].normal;
        direction = Vector2.Reflect(direction, normal);
        rb.velocity = direction * speed;
    }
    private IEnumerator DestroyBulletAfterDelay(float delay)
    {  
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Log the position right before destruction
        target.transform.position = transform.position;

        // Destroy the bullet
        Destroy(gameObject);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    bool hasDamaged = false;
    public float speed;
    Frog frog;

    void Start()
    {
        frog = FindObjectOfType<Frog>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,              
            frog.transform.position,         
            speed * Time.deltaTime         
        );
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mouth"))
        {
            frog.AddScore();
            Destroy(gameObject);
            return;
        }

        if (other.CompareTag("Player") && !hasDamaged)
        {
            hasDamaged = true;

            speed = 0f;                    // stop moving
            transform.parent = other.transform; // stick to frog
            frog.TakeDamage();
        }
    }


}

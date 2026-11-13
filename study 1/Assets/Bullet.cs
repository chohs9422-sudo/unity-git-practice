using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    void Start()
    {
        
        Invoke("DestroySelf", 2.0f);
    }

    void DestroySelf()
    {
        
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("부딪힌 물체: " + collision.name);

        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(damage); 
            Destroy(gameObject);      
        }
    }
}

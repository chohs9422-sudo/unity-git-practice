using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHp = 3;
    private int currentHp;

    void Start()
    {
        currentHp = maxHp; 
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log("적군 남은 체력: " + currentHp);

        if (currentHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] float maxHealth;
    private float health;
    private bool isAlive;

    private void Awake()
    {
        health = maxHealth;
        isAlive = true;
    }
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        CheckAlive();
    }

    private void CheckAlive()
    {
        if (health > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false;
        }
    }


}

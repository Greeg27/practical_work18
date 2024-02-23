using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    [SerializeField] float maxHealth;
    [SerializeField] CanvasScript canvas;
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
        canvas.PlayerHealthDisplay(health / maxHealth);
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
            canvas.DeathPanelSetActiv();
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //if (collision.tag == "")
    //    //{

    //    //}
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if  (collision.tag == "Damage")
        {
            TakeDamage(1);
        }
    }
}

using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            animator.Play("Explosion");
        }
    }
}

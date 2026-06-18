using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction = Vector3.right;
    public float speed = 10f;
    void Start()
    {
        Destroy(gameObject, 3f);

    }

    
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("BOOM");
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}

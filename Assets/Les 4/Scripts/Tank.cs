using UnityEngine;

public class Tank : MonoBehaviour
{

    float horizontal;
    float vertical;

    float speed = 5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        //Debug.Log(horizontal);
        
        transform.Rotate(Vector3.forward, -horizontal);
        transform.Translate(Vector3.right *  vertical * Time.deltaTime * speed);
        
    }
}

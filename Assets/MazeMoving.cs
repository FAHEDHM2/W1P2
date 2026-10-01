using UnityEngine;
using System.Collections;

public class MazeMoving : MonoBehaviour
{
   public float speed = 10.0f;
    public float rotation = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

    }
       
    
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * speed;
        transform.rotation = Quaternion.Euler(translation, 0, rotation);
       
    }
}

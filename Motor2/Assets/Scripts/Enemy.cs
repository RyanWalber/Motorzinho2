using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
        public float speed;
        public bool ground = true;
        public Transform groundCheck;
        public LayerMask groundLayer;
         void Start()
         {

         }
    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        ground = Physics2D.Linecast(groundCheck.position, transform.position, groundLayer);
        Debug.Log(ground);
    }
}

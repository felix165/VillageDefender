using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script for setting bullet movement
// put this in the bullet gameobject with rigidbody2d
public class bulletMovement : MonoBehaviour
{
    [SerializeField] private float speed; //kecepatan bullet bergerak ke kanan

    Rigidbody2D bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bulletDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate (transform.right * speed * Time.deltaTime);

    }
}

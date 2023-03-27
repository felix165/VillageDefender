using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for enemy movement

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemyChar;
    [SerializeField] private float speed;//kecepatan musuh bergerak
    float updateSpeed; //kecepatan pada saat ini (akibat efek slow)
    float slowTime = 2.0f; //waktu efek slow mempengaruhi musuh
    public bool slow; //kondisi slow 
    public bool obstacle; //kondisi movement jika mendeteksi penghalang maka musuh tidak dapat bergerak

    Rigidbody2D enemy;

    // Start is called before the first frame update
    void Start()
    {
        slow = false;
        obstacle = false;
    }

    void slowEffect()
    {
        updateSpeed = (float)(speed -0.5f);
        slow = false;
        slowTime = 2.0f;

    }
   
    // Update is called once per frame
    void Update()
    {


        if (Time.timeScale != 0)
        {
            if (slow == true)
            {
                Debug.Log("slow");
                slowEffect();
            }


            if (slowTime > 0.0f)
            {
                slowTime -= Time.deltaTime;
            }
            else 
            {
                updateSpeed = speed;

            }


            if(obstacle == true)
            {
                
                enemyChar.transform.Translate(transform.right * updateSpeed * 0 * -1);

            }
            if (obstacle ==false)
            {
                enemyChar.transform.Translate(enemyChar.transform.right * updateSpeed * Time.deltaTime * -1);
            }

        }
    }
}

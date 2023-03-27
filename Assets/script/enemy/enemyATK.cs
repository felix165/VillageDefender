using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//script for detect ally and attack it
//
public class enemyATK : MonoBehaviour
{
    public GameObject movement; 
    GameObject allyChar; 
    bool attack; //kondisi apakah karakter perlu menyerang atau tidak
    [SerializeField] float enemyDMG = 1.0f; //damage yang diberikan ke karakter
    [SerializeField] float enemyAtkSpeed = 1.0f; //kecepatan menyerang
    float AtkTimeCounter; //counter waktu tersisa untuk serangan berikut

    // Start is called before the first frame update
    void Start()
    {
        attack = false;
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "allyChar")
        {
            allyChar = obj.gameObject;
            AtkTimeCounter = 0.0f;
            attack = true;
            movement.GetComponent<EnemyMovement>().obstacle = true;
            Debug.Log("ally detected");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(attack == true)
        {
            if (allyChar == null)
            {
                attack = false;
                movement.GetComponent<EnemyMovement>().obstacle = false;
            }
            else
            {
                AtkTimeCounter -= Time.deltaTime;
                if (AtkTimeCounter <= 0)
                {
                    AtkTimeCounter = enemyAtkSpeed;
                    allyChar.GetComponent<allyCondition>().Hp -= enemyDMG;
                    Debug.Log("ally :"+allyChar.GetComponent<allyCondition>().Hp );


                }
            }
        }
    }
}

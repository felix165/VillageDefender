using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//put this script in the same gameobject with enemy movement script
//this script have any data about enemy condition and can destroy the enemy ;
public class enemyCondition : MonoBehaviour
{
    public GameObject data;
    public GameObject movement; 
    public float maxHp = 3.0f;//max hp
    public float Hp ; //current hp 
    float normalBulletDMG = 0.5f; //damage peluru normal
    float slowBulletDMG = 0.5f; //damage peluru dengan efek slow
    float fireBallDMG = 1.5f; //damage peluru api
    float WolfEnergyDMG = 6.0f; //damage wolfEnergy


    // Start is called before the first frame update
    void Start()
    {
        Hp = maxHp;
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        Debug.Log(obj);

        if (obj.gameObject.tag == "slowEffect")
        {
            Destroy(obj.gameObject);
            movement.GetComponent<EnemyMovement>().slow = true;
            Hp -= slowBulletDMG;
        }else if (obj.gameObject.tag == "normal")
        {
            Destroy(obj.gameObject);
            Hp -= normalBulletDMG;
        }
        else if (obj.gameObject.tag == "fireBall")
        {
            Destroy(obj.gameObject);
            Hp -= fireBallDMG;
        }else if(obj.gameObject.tag == "wolfEnergyBall")
        {
            Destroy(obj.gameObject);
            Hp -= WolfEnergyDMG;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //score hanya bertambah bila belum game over
        if (Hp <= 0.0f)
        {
            Hp = 0.0f;
            Debug.Log("enemy Killed");
            if(data.GetComponent<data>().gameOver == false)
            {
                data.GetComponent<data>().score += 1;
            }

            Destroy(this.gameObject);
        }
    }
}

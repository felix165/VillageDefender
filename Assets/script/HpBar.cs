using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    
    public GameObject character; //karakter
    private float healthAmount; //persentase sisa Hp yang dimiliki
    private float realScale; //ukuran asli hpBar sebelum berubah berdasarkan persentase Hp
    Vector3 localScale;
    public bool thisIsAlly = false; //informasi berupa karakter yang dipasangkan dengan HPbar
    
    // Start is called before the first frame update
    void Start()
    {
        realScale = transform.localScale.x;
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (thisIsAlly)
        {
            healthAmount = realScale * (character.GetComponent<allyCondition>().Hp / character.GetComponent<allyCondition>().maxHp);

        }
        else
        {
            healthAmount = realScale * (character.GetComponent<enemyCondition>().Hp / character.GetComponent<enemyCondition>().maxHp);

        }
        localScale.x = healthAmount;
        transform.localScale = localScale;
    }
}

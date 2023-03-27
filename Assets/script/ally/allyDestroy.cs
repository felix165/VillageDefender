using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script can detect ally hp, when its hp getting under 0, this gameobject will be destroy

public class allyDestroy : MonoBehaviour
{
    public GameObject ally;
    float Hp; //current hp
    // Start is called before the first frame update
    void Start()
    {
        Hp = ally.GetComponent<allyCondition>().Hp;
    }

    // Update is called once per frame
    void Update()
    {
        Hp = ally.GetComponent<allyCondition>().Hp;
        if (Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

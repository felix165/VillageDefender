using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//script that have data about ally hp
public class allyCondition : MonoBehaviour
{

    public GameObject data;
    public float maxHp = 3.0f; //max hp
    public float Hp = 3.0f ; //current hp

    // Start is called before the first frame update
    void Start()
    {
        Hp = maxHp;
    }

    void OnMouseClick()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//penghancur objek yang diluar batas arena
public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.gameObject.tag != "enemy")
        {
            Destroy(obj.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

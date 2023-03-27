using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script untuk mendeteksi musuh
public class enemyDetector : MonoBehaviour
{
    public GameObject gmObj;
    GameObject enemy;
    public bool enemyIsDetected; //kondisi apakah musuh terdeteksi
    // Start is called before the first frame update
    void Start()
    {
        enemyIsDetected = false;
        //memastikan posisi detektor berada pada posisi yang tepat
        transform.localPosition = new Vector3(transform.localPosition.x - gmObj.transform.localPosition.x, transform.localPosition.y, this.transform.localPosition.z) ;

    }

    void OnTriggerEnter2D (Collider2D obj)
    {
        if(obj.gameObject.tag == "enemy")
        {
            enemyIsDetected = true;
            Debug.Log("enemy detected");
            enemy = obj.gameObject;
        }
    }


    // Update is called once per frame
    void Update()
    { 
        if (enemyIsDetected == true)
        {
            if (enemy == null)
            {
                enemyIsDetected = false;
            }
        }
    }
}

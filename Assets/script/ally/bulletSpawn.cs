using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//spawn bullet
public class bulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public GameObject detector;

    [SerializeField] private float interval ; //waktu yang dibutuhkan untuk menembakkan 1 serangan
    float intervalLeft;//waktu tersisa untuk menembakkan serangan berikutnya


    // Start is called before the first frame update
    void Start()
    {
        intervalLeft = interval;
    }


    // Update is called once per frame
    void Update()
     {//karakter akan menyerang ketika mendeteksi musuh
        if (detector.GetComponent<enemyDetector>().enemyIsDetected == true)
        {
            Debug.Log("enemy detect spawn bullet");
            intervalLeft -= Time.deltaTime;
            if (intervalLeft <= 0.0f)
            {
                intervalLeft = interval;
                Instantiate(bullet, transform.position, transform.rotation);

                Debug.Log("bullet spawned");
            }
        }
    }
}

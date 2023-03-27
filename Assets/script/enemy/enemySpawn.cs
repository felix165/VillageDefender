using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public GameObject data;
    public List<GameObject> enemyChar = new List<GameObject>();
    public List <Transform> spawnPos = new List <Transform>();
    [SerializeField] private float spawnSpeed = 7.0f; //kecepatan spawn
    [SerializeField] private float waveCount = 120.0f; //jumlah waktu setiap wave
    [SerializeField] private float timeBreak = 10.0f; //break setiap masuk wave
    [SerializeField] private float firstWaveTimeBreak = 25.0f; //break pada wave pertama
    float breakTimeCount; //sisa waktu break
    float waveTimeCount; //sisa waktu wave
    float spawnTimeCount; //sisa waktu spawn untuk spawn berikutnya
    bool stopSpawning; //kondisi spawn, untuk sesi break
    bool changeWave; //kondisi pergantian wave
    int temp;
    // Start is called before the first frame update
    void Start()
    {
        waveTimeCount = waveCount;
        spawnTimeCount = spawnSpeed;
        breakTimeCount = firstWaveTimeBreak;
        stopSpawning = true;
        changeWave = true;
        temp = 0;
    }


    void spawn()
    {
        GameObject obj = enemyChar[Random.Range(0,(enemyChar.Count - 8 + temp))];
        Instantiate(obj, spawnPos[(Random.Range(0, spawnPos.Count))].position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {


        if (data.GetComponent<data>().gameOver != true)
        {
            waveTimeCount -= Time.deltaTime;
            if (waveTimeCount <= 0)
            {
                waveTimeCount = waveCount;
                breakTimeCount = timeBreak;
                if(data.GetComponent<data>().waveCounter < 5)
                {
                    data.GetComponent<data>().waveCounter += 1;
                    temp += 2;

                }
                if (data.GetComponent<data>().waveCounter <= 5)
                {
                    changeWave = true;
                    stopSpawning = true;
                }

                if (data.GetComponent<data>().waveCounter <= 4)
                {
                    spawnSpeed -= 2.0f;

                }
                else if (data.GetComponent<data>().waveCounter == 5)
                {
                    waveTimeCount = waveCount - 15.0f;
                    spawnSpeed -= 0.8f;
                    
                }
                else
                {
                    stopSpawning = true;
                    data.GetComponent<data>().gameOver = true;
                }


            }

            if (changeWave == true && stopSpawning == true)
            {
                breakTimeCount -= Time.deltaTime;
                if (breakTimeCount <= 0)
                {
                    breakTimeCount = timeBreak;
                    for (int i = 0; i < (data.GetComponent<data>().waveCounter-1) * 3; ++i)
                    {
                        spawn();
                    }

                    stopSpawning = false;
                    changeWave = false;

                }
            }


            if (!stopSpawning)
            {
                spawnTimeCount -= Time.deltaTime;
                if (spawnTimeCount <= 0)
                {
                    spawnTimeCount = spawnSpeed;
                    spawn();
                }
            }
            else
            {

            }


        }  
    }
}

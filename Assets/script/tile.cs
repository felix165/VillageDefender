using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script for tile, for spawn unit

public class tile : MonoBehaviour
{
    public GameObject data;

    private bool allySpawned; //apakah terdapat karakter yang telah dispawn di posisi tile ini
    GameObject ally; //karakter yg dispawn
    

    // Start is called before the first frame update
    void Start()
    {
        allySpawned = false;
    }
    void OnMouseDown()
    {
        Debug.Log("tile selected");
        //berjalan ketika tidak ada karakter di posisi ini
        if (allySpawned == false)
        {
            //mengecek dan memunculkan karakter yang telah dipilih sebelumnya dengan pengecekan pada array
            for (int i = 0; i < data.GetComponent<data>().character.Count; i++)
            {
                if (data.GetComponent<data>().charSelected[i] == true)
                {
                    Debug.Log("charSpawn");
                    if (data.GetComponent<data>().elixir - data.GetComponent<data>().SpawnCost[i] >= 0) 
                    {

                        data.GetComponent<data>().elixir -= data.GetComponent<data>().SpawnCost[i];
                        ally = Instantiate(data.GetComponent<data>().character[i], transform.position, transform.rotation);
                        allySpawned = true;

                        data.GetComponent<data>().charSelected[i] = false;

                        Debug.Log(ally);
                    }
                    else
                    {
                        Debug.Log("out of elixirs");
                    }
                }
            }
        }
        else
        {
            //mengecek keberadaan karakter pada tile ini
            //jika karakter telah mati, maka tile dapat digunakan ulang
            if (data.GetComponent<data>().destoryerSelected == true)
            {
                data.GetComponent<data>().destoryerSelected = false;
                ally.GetComponent<allyDestroy>().ally.GetComponent<allyCondition>().Hp = 0;
                allySpawned = false;
            }

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (allySpawned == true)
        {
            if (ally == null)
            {
                allySpawned = false;
            }
        }
    }
}

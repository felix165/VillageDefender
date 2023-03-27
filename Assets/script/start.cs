using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject data; 
    public int elixir; //jumlah elixir pada awal bermain
    public int score; //score pada awal bermain
    public float delta_time = 600f; //total waktu awal bermain
    public int waveCounter; //jumlah wave awal main
    List<bool> charSelected; //kondisi terpilihnya karakter

    // Start is called before the first frame update
    void Start()
    {
        data.GetComponent<data>().gameOver = false; 
        data.GetComponent<data>().destoryerSelected = false;
        charSelected = data.GetComponent<data>().charSelected;
        data.GetComponent<data>().elixir = elixir;
        data.GetComponent<data>().score = score;
        data.GetComponent<data>().delta_time = delta_time;
        data.GetComponent<data>().waveCounter = waveCounter;
        data.GetComponent<data>().charSelected.Clear();
        for (int i = 0; i < data.GetComponent<data>().character.Count; i++)
        {
            data.GetComponent<data>().charSelected.Add(false);
        }
        Debug.Log(data.GetComponent<data>().character.Count);
        Debug.Log(data.GetComponent<data>().charSelected.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

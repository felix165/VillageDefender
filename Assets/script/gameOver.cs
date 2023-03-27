using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    public GameObject data;
    public GameObject fence; //gambar pagar yang hilang jika game over
    public GameObject GameOverObj; //gameover object
    int waveTemp; //menyimpan jumlah wave sesaat sebelum gameover
    int ScoreTemp; //menyimpan jumlah score sesaat sebelum gameover
    // Start is called before the first frame update
    void Start()
    {
        fence.SetActive(true);
        GameOverObj.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        //ketika enemy sampai pada daerah kiri, maka program ini akan terpicu
        if(obj.gameObject.tag == "enemy")
        {
            fence.SetActive(false);
            waveTemp = data.GetComponent<data>().waveCounter;
            ScoreTemp = data.GetComponent<data>().score;
            data.GetComponent<data>().gameOver = true;
            GameOverObj.SetActive(true);
        }
        Destroy(obj.gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        //menjaga agar jumlah wave dan score tidak berubah saat gameover
        if (data.GetComponent<data>().gameOver)
        {
            data.GetComponent<data>().waveCounter = waveTemp;
            data.GetComponent<data>().score = ScoreTemp;
        }
    }
}

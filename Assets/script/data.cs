using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//full of data 
//put this in the blank or start gameobject
public class data : MonoBehaviour
{
    public List  <GameObject> character = new List <GameObject>(); //list yang menyimpan semua karakter yang dapat dispawn
    public List <bool> charSelected = new List<bool>(); //list untuk menyimpan boolean, membantu dalam mendeteksi karakter yang dipilih pemain
    public List<int> SpawnCost = new List<int>(); //list yang menyimpan harga karakter yang perlu dibayar ketika dispawn

    public bool destoryerSelected; //boolean yang menandakan tombol delete dalam kondisi dipilih atau tidak

    public int elixir; //jumlah elixir
    public int score; //score yang telah didapat
    public float delta_time ; //total waktu tersisa, untuk bertahan melawan musuh
    public int waveCounter; //jumlah wave pada saat ini

    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

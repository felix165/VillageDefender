using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveCounter : MonoBehaviour
{
    public GameObject data;
    public Text waveText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = (data.GetComponent<data>().waveCounter).ToString("0") + "/5";
    }
}

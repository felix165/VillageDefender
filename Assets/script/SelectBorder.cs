using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// for detect mouse click when player want to select ally to spawn



public class SelectBorder : MonoBehaviour
{
    public GameObject objSelector; //obj aktif ketika karakter diclick
    public GameObject data;
    [SerializeField] private int charCode; //code karakter pada border ini
    bool temp;
    // Start is called before the first frame update
    void Start()
    {
        objSelector.SetActive(false);
    }

    void OnMouseDown()
    {
        //memastikan border lain dalam keadaan off jika ada 1 border yang dipilih
        //pilihan pada border dapt dibatalkan jika menekan border kembali
        if (charCode != -1)
        {
            data.GetComponent<data>().charSelected[charCode] = !(data.GetComponent<data>().charSelected[charCode]);

        } 
        else if (charCode == -1)
        {
            Debug.Log("delete");

            data.GetComponent<data>().destoryerSelected = !(data.GetComponent<data>().destoryerSelected);

        }

        for (int i = 0; i < data.GetComponent<data>().charSelected.Count; i++)
        {
            if(i != charCode)
            {
                data.GetComponent<data>().charSelected[i] = false;
            }
            
        }
        if (charCode != -1)
        {
        data.GetComponent<data>().destoryerSelected =false;
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        if (data.GetComponent<data>().destoryerSelected)
        {
            Debug.Log("delete on?");

        }
        if(charCode != -1)
        {
            if (data.GetComponent<data>().charSelected[charCode] )
            {
                objSelector.SetActive(true);
            }
            else
            {
                objSelector.SetActive(false);

            }
        }
        else
        {
            if (data.GetComponent<data>().destoryerSelected)
            {
                objSelector.SetActive(true);
            }
            else
            {
                objSelector.SetActive(false);

            }
        }

    }
}
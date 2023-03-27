using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elixir : MonoBehaviour
{
    public Text elixirText;

    public GameObject data;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elixirText.text = (data.GetComponent<data>().elixir).ToString("0");
    }
}

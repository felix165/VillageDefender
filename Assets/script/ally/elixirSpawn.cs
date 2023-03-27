using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class elixirSpawn : MonoBehaviour
{
    public GameObject elixir; //elixir
    [SerializeField] private float interval; //interval spawn elixir
    float intervalLeft; //waktu tersisa sebelum spawn berikutnya


    // Start is called before the first frame update
    void Start()
    {
        intervalLeft = interval;
    }


    // Update is called once per frame
    void Update()
    {
        intervalLeft -= Time.deltaTime;
        if (intervalLeft <= 0.0f)
        {
            intervalLeft = interval;
            Instantiate(elixir, transform.position, transform.rotation);

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for spawn the tile

public class lawnSpawner : MonoBehaviour
{
    int temp;
    public int lawn_height = 5; //banyak x tile yang ingin dibuat
    public int lawn_weight = 9; //banyak y tile yang ingin dibuat

    public GameObject p_tile1; //tile pertama
    public GameObject p_tile2; //tile kedua
    GameObject tile_temp;


    void Start()
    {
        generateLawn();
        temp = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mouseClick();
        }
    }
    //Membuat lahan dengan membuat tile dengan jumlah yang telah ditentukan
    private void generateLawn()
    {
        for (int i = 0; i < lawn_height; i++)
        {
            temp = 0;
            tile_temp = p_tile1;
            p_tile1 = p_tile2;
            p_tile2 = tile_temp;
            for (int j = 0; j < lawn_weight; j++)
            {
                ++temp;
                if (temp % 2 == 0)
                {
                    GameObject tile = Instantiate(p_tile1, new Vector2((float)j - lawn_weight / 2, ((float)i - lawn_height / 2)) * 2, Quaternion.identity, transform);
                }
                else
                {
                    GameObject tile = Instantiate(p_tile2, new Vector2((float)j - lawn_weight / 2, ((float)i - lawn_height / 2))*2, Quaternion.identity, transform);

                }

            }
        }
    }

    private void mouseClick()
    {
        Ray ray;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "tile")
            {
                Debug.Log(hit.transform);
            }
        }
    }
}

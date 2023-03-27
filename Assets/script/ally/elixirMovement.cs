using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elixirMovement : MonoBehaviour
{
    public GameObject data;
    [SerializeField] private int elixirAmount;

    float currentPosX; //posisi x spawner saat ini
    float currentPosY; //posisi y spawner saat ini
    float Ypos; //posisi random y elixir ketika dispawn
    float Xpos;//posisi random x elixir ketika dispawn

    // Start is called before the first frame update
    void Start()
    {
        currentPosX = this.transform.localPosition.x;
        currentPosY = this.transform.localPosition.y;
        Debug.Log(currentPosX);
        Debug.Log(currentPosY);
        Ypos = Random.Range((currentPosY - 0.8f), (currentPosY + 0.8f));
        Xpos = Random.Range((currentPosX - 0.8f), (currentPosX + 0.8f));
        transform.localPosition = new Vector3(Xpos, Ypos, this.transform.localPosition.z) ;

    }

    void OnMouseDown()
    {
        data.GetComponent<data>().elixir += elixirAmount;
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public GameObject data;
    [SerializeField] private float waveCount = 120.0f;
    public GameObject gameOver;

    public GameObject timeBar;
    private float realScale;
    private float updateScale;
    Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        realScale = transform.localScale.x;
        localScale = transform.localScale;
        updateScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        data.GetComponent<data>().delta_time -= Time.deltaTime;


        updateScale = realScale * ((data.GetComponent<data>().delta_time % waveCount) / waveCount);
        if (data.GetComponent<data>().delta_time % waveCount == 0)
        {
            localScale.x = realScale  ;
        }
        else
        {
            localScale.x = updateScale;
        }
        transform.localScale = localScale;


        if (data.GetComponent<data>().delta_time <= 0)
        {
            gameOver.SetActive(true);


        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public AudioSource ClickSoundEffect; //sound effect ketika tombol exit ditekan

    bool clicked;
    private float delayTime; //waktu delay sebelum keluar game saat tombol diklik
    // Start is called before the first frame update
    void Start()
    {
        delayTime = 0.5f;
        clicked = false;
    }
    //Tombol keluar dari game
    private void OnMouseDown()
    {
        ClickSoundEffect.Play();
        clicked = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked == true)
        {

            delayTime -= Time.deltaTime;
            if (delayTime <= 0)
            {

                Application.Quit();
            }
        }
    }
}

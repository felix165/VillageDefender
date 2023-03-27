using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    public AudioSource ClickSoundEffect; //soundeffet ketika tombol ditekan
    bool clicked; //kondisi tombol 

    private float delayTime;//delay sebelm menjalankan perintah pindah scene atau halaman

    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
        delayTime = 0.5f;
    }

    void OnMouseDown()
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
                delayTime = 0.5f;
                clicked = false;
                SceneManager.LoadScene(0);
            }
        }
    }
}

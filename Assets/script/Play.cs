using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public int GameScene = 2; //game scene
    public AudioSource ClickSoundEffect; //sound effect ketika tombol ditekan
    bool clicked; //tombol diclick atau tidak

    private float delayTime;

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
        if(clicked == true)
        {
            delayTime -= Time.deltaTime;
            if(delayTime <= 0)
            {
                clicked = true;
                delayTime = 0.5f;
                SceneManager.LoadScene(GameScene);
            }
        }
    }
}

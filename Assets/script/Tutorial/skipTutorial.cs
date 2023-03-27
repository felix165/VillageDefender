using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipTutorial : MonoBehaviour
{
    public int GameScene = 2;
    public AudioSource ClickSoundEffect;
    bool clicked;

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
        if (clicked == true)
        {
            delayTime -= Time.deltaTime;
            if (delayTime <= 0)
            {

                SceneManager.LoadScene(GameScene);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//sound akan berjalan terus menerus selama game masih dibuka
public class BGMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private static BGMusic music = null; //musik latar
    public static BGMusic Music
    {
        get { return music; }
    }
    // Start is called before the first frame update
    void Awake()
    {
        if (music != null && music != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            music = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

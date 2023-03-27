using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class page : MonoBehaviour
{
    public GameObject tutorialData;
    public Text pageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pageText.text = (tutorialData.GetComponent<tutorial>().page + 1).ToString("0") + "/" + (tutorialData.GetComponent<tutorial>().tutorialObj.Count).ToString("0");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    public List<GameObject> tutorialObj = new List<GameObject>();
    public GameObject next;
    public GameObject previous;
    public int page;
    // Start is called before the first frame update
    void Start()
    {
        page = 0;
        next.SetActive(true);
        previous.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (page >= tutorialObj.Count - 1)
        {
            page = tutorialObj.Count - 1;
            next.SetActive(false);
        }
        else
        {
            next.SetActive(true);
        }

        if (page <= 0)
        {
            page = 0;
            previous.SetActive(false);
        }
        else
        {
            previous.SetActive(true);
        }

        tutorialObj[page].SetActive(true);

        for (int i = 0; i < tutorialObj.Count; ++i)
        {
            if (i != page)
            {
                tutorialObj[i].SetActive(false);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    float countTime = 0;
    public GameObject[] icons;

    public void UpdateBody(int body)
    {
        for(int i =0;i<icons.Length;i++)
        {
            if (i < body) icons[i].SetActive(true);
            else icons[i].SetActive(false);
            
        }
    }
 
    void Start()
    {
        
    }

 
    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        GetComponent<Text>().text = countTime.ToString("F2");
        
    }
}

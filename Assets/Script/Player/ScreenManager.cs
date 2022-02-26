using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
   //時間を初期化。まとめて透過率を変更
    
    float countTime = 0;
    public GameObject[] icons;
 //体に応じてスプライトを出しわける。
 public void UpdateBody(int body)
    {
        for(int i = 0; i < icons.Length; i++)
        {
            if (i < body) icons[i].SetActive(true);
            else icons[i].SetActive(false);
        }
    }

    void Start()
    {
    
    }
  
    
    

    //タイマーのアップデート
    void Update()
{
    countTime += Time.deltaTime;
    GetComponent<Text>().text = countTime.ToString("F2");
}
}
   

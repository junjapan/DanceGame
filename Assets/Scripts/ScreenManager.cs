using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    float countTime = 0;
    private static CanvasGroup canvasObj;
 
    void Start()
    {
        canvasObj = GameObject.Find("Canvas").GetComponent<CanvasGroup>();
        canvasObj.alpha = 0.0f;
        
    }
    public static void OpenPanelScript(MonoBehaviour crt,GameObject item)
    {
        crt.StartCoroutine(OpenEffect(item));
    }
    private static IEnumerator OpenEffect(GameObject item)
    {
        item.transform.parent = canvasObj.transform;
        float y = canvasObj.transform.position.y + 1.0f;
        item.transform.position = canvasObj.transform.position;
        for (float i = 0.0f; i < 1.0f; i = i + 0.01f)
        {
            canvasObj.alpha = i;
            yield return null;
        }
        canvasObj.alpha = 1.0f;
      
    }

    // Update is called once per frame
    void Update()
{
    countTime += Time.deltaTime;
    GetComponent<Text>().text = countTime.ToString("F2");
}
}
   

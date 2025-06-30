using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float StopWatchCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StopWatch());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator StopWatch()
    {
        while (true)
        {
            yield return null;
            StopWatchCount += Time.deltaTime;
            Debug.Log(StopWatchCount);
        }
    }
}

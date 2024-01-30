using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI TimerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool stopWatch;

    // Update is called once per frame
    void Update()
    {
        currentTime = stopWatch ? currentTime += Time.deltaTime : currentTime -= Time.deltaTime;
        TimerText.text = currentTime.ToString("0");
    }
}

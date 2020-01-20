using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    public float currentTime = 0;
    public float maxTime = 0;
    public bool paused = false;
    private bool countingDown = true;

    public bool CountingDown { get => countingDown; set => countingDown = value; }

    public void Start(float max)
    {
        maxTime = max;
        currentTime = maxTime;
    }

    public void Tick()
    {
        if (!paused)
        {
            if(CountingDown)
            {
                currentTime -= Time.deltaTime;
            }
            else
            {
                currentTime += Time.deltaTime;
            }
        }
    }

    public void ResetTimer()
    {
        currentTime = maxTime;
    }

    public void TogglePause()
    {
        paused = !paused;
    }
}
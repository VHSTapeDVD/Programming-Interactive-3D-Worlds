using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Flicker : MonoBehaviour
{
    private Light lightComponent;
    public float interval = 1.0f; // Interval duration in seconds
    private float elapsedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= interval)
        {
            lightComponent.enabled = !lightComponent.enabled;
            elapsedTime = 0.0f;
        }
    }
}
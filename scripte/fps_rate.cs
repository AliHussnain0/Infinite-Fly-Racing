using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class fps_rate : MonoBehaviour
{
    private float fps
        ;
    public TMPro.TextMeshProUGUI FpsCounterText;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GetFPS", 1, 1);
    }

    // Update is called once per frame
    void GetFPS()
    {
        fps = (int)(1f / Time.unscaledDeltaTime);
        FpsCounterText.text = "FPS: " + fps.ToString();
    }
}

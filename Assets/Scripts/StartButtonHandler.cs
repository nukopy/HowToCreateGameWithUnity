using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    private bool _isButtonPressedOnce = false;

    // private void Start()
    // {
    //     GameObject g = GameObject.Find("Directional Light");
    //     if (g == null) return;
    //     Light light = g.GetComponent<Light>();
    //     if (light == null) return;
    //     
    //     Debug.Log("Directional light intensity: " + light.intensity);
    //     light.intensity = 0.5f;
    //     Debug.Log("Directional light intensity: " + light.intensity);
    // }

    public void OnClickStartButton()
    {
        Debug.Log("Start button pressed!!");
        
        // 次のシーンへ進む（2 回目以降のクリックを無効化）
        if (!_isButtonPressedOnce)
        {
            _isButtonPressedOnce = true;
            Debug.Log("Go to the next scene!");
        }
    }
}

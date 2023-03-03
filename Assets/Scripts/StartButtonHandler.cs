using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonHandler : MonoBehaviour
{
    private bool _isButtonPressedOnce = false;
    
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

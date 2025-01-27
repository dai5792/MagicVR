using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FPSDisplay : MonoBehaviour
{

    int frameCount;
    float prevTime;
    float fps;

    void Start()
    {
        // 変数の初期化
        frameCount = 0;
        prevTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        frameCount++;
        float time = Time.realtimeSinceStartup - prevTime;

        if (time >= 0.5f)
        {
            fps = frameCount / time;
            Debug.Log(fps);

            frameCount = 0;
            prevTime = Time.realtimeSinceStartup;
        }
    }

    // 表示処理
    private void OnGUI()
    {
        GUILayout.Label(fps.ToString());
    }
}

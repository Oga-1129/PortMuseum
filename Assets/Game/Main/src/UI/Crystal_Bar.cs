using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class Crystal_Bar : MonoBehaviour
{

    public bool barmove = false;
    Slider _slider;

    GameObject Crystal_Canvas;
    Crystal_Canvas Crystal_Canvasscript;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Crystal_Bar").GetComponent<Slider>();
        Crystal_Canvas = GameObject.Find("Crystal_Canvas");
        Crystal_Canvasscript = Crystal_Canvas.GetComponent<Crystal_Canvas>();
    }

    float logingage = 0;
    void Update()
    {
        if (barmove)
        {
            // ゲージの上昇
            logingage += 0.005f;
            // ゲージに値を設定
            _slider.value = logingage;

            if (logingage >= 1)
            {
                Crystal_Canvasscript.Login = true;
            }
        }
    }
}

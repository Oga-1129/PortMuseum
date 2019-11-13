using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class CrystalBar: MonoBehaviour {

    public bool barmove = false; 
    Slider _slider;

    GameObject CrystalCanvas;
    CrystalCanvas crystalcanvasscript;
    void Start () {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
        CrystalCanvas = GameObject.Find("Canvas");
        crystalcanvasscript = CrystalCanvas.GetComponent<CrystalCanvas>();
    }

    float logingage = 0;
    void Update () 
    {
        if(barmove){
            // ゲージの上昇
            logingage += 0.005f;
            // ゲージに値を設定
            _slider.value = logingage;

            if(logingage >= 1)
            {
                crystalcanvasscript.Login = true;
            }
        }
    }
}

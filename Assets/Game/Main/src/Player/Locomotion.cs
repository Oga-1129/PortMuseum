using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{

    //Unityの公式スクリプトレファンスにあるものと同じ
    //十字キーのみで操作(矢印キー＝前後左右移動)
    //CharacterControllerが必要

    public float forwardspeed = 6.0F;    //前進速度
    public float angleSpeed = 200;
    public float jumpSpeed = 8.0F;   //ジャンプ力
    public float gravity = 20.0F;    //重力の大きさ

    public bool SeachBool;

    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    private float h, v;

    GameObject AnimUI;
    Animation_UI animuiscript;

    GameObject CrystalBarUI;
    Crystal_Bar crystalbarscript;

    GameObject CrystalCanvas;
    Crystal_Canvas crystalcanvasscript;

    private Animator animator;

    // 設定したフラグの名前
    private const string key_isRun = "IsRun";
    private const string key_isJump = "IsJump";

    private const string playerspeed = "Speed";

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();

        // 自分に設定されているAnimatorコンポーネントを習得する
        this.animator = GetComponent<Animator>();

        AnimUI = GameObject.Find("ProfileUI");
        animuiscript = AnimUI.GetComponent<Animation_UI>();

        CrystalBarUI = GameObject.Find("Crystal_Bar");
        crystalbarscript = CrystalBarUI.GetComponent<Crystal_Bar>();

        CrystalCanvas = GameObject.Find("Crystal_Canvas");
        crystalcanvasscript = CrystalCanvas.GetComponent<Crystal_Canvas>();
    }//Start()

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * forwardspeed * Time.deltaTime;
            animator.SetBool(key_isRun, true);
        }
        else
        {
            // animator.SetBool("Walk", false);
            animator.SetBool(key_isRun, false);
        }


        if (Input.GetKey(KeyCode.S) && SeachBool)
        {
            //animator.SetBool("Seach", true);
            crystalcanvasscript.Gage = true;
            //animuiscript.OpenUI = true;
        }


        if (Input.GetKey(KeyCode.D))
        {
            float right = Input.GetAxisRaw("Horizontal") * Time.deltaTime * angleSpeed;
            transform.Rotate(Vector3.up * right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            float left = Input.GetAxisRaw("Horizontal") * Time.deltaTime * angleSpeed;
            transform.Rotate(Vector3.up * left);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Wait or RunからJumpに遷移する
            this.animator.SetBool(key_isJump, true);
        }
        else
        {
            // JumpからWait or Runに遷移する
            this.animator.SetBool(key_isJump, false);
        }

    }//Update()

}
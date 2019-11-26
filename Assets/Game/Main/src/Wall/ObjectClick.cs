using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public Camera camera_object; //カメラを取得
    private RaycastHit hit; //レイキャストが当たったものを取得する入れ物
    public float[,,] objectdate;

    public string objectName;

    GameObject receiver;
    Create_Controller createscript;

    int wall_num = 0;

    void Start()
    {
        receiver = GameObject.Find("Create_Controller");
        createscript = receiver.GetComponent<Create_Controller>();
        objectdate = new float[100, 4, 4];
        objectdate[0, 0, 0] = 0.0f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //マウスがクリックされたら
        {
            Ray ray = camera_object.ScreenPointToRay(Input.mousePosition); //マウスのポジションを取得してRayに代入
            if (Physics.Raycast(ray, out hit))  //マウスのポジションからRayを投げて何かに当たったらhitに入れる
            {
                objectName = hit.collider.gameObject.name; //オブジェクト名を取得して変数に入れる
                objectdate[wall_num, 1, 1] = hit.collider.gameObject.transform.position.x; //オブジェクトx座標を取得して変数に入れる
                objectdate[wall_num, 1, 2] = hit.collider.gameObject.transform.position.y; //オブジェクトy座標を取得して変数に入れる
                objectdate[wall_num, 1, 3] = hit.collider.gameObject.transform.position.z; //オブジェクトz座標を取得して変数に入れる
                objectdate[wall_num, 2, 1] = hit.collider.gameObject.transform.localScale.x; //オブジェクトxサイズを取得して変数に入れる
                objectdate[wall_num, 2, 2] = hit.collider.gameObject.transform.localScale.y; //オブジェクトyサイズを取得して変数に入れる
                objectdate[wall_num, 2, 3] = hit.collider.gameObject.transform.localScale.z; //オブジェクトzサイズを取得して変数に入れる
                objectdate[wall_num, 3, 1] = hit.collider.gameObject.transform.rotation.x; //オブジェクトx角度を取得して変数に入れる
                objectdate[wall_num, 3, 2] = hit.collider.gameObject.transform.rotation.y; //オブジェクトy角度を取得して変数に入れる
                objectdate[wall_num, 3, 3] = hit.collider.gameObject.transform.rotation.z; //オブジェクトz角度を取得して変数に入れる
            }
        }
    }
}

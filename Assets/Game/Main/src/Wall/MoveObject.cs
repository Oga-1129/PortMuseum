using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObject : MonoBehaviour
{
    GameObject[] objGet = new GameObject[6];
    MoveScale[] script = new MoveScale[6];
    public int wall_num;

    float[] pos = new float[2];

    float rot;
    
    GameObject receiver;
    CreateController createscript;

    GameObject DeleteButton;
    DeleteButton Deletescript;

    Quaternion angle = Quaternion.identity;

    GameObject createBtn;
    CreateButton crebtnscript;

    GameObject destroycontroller;
    DestroyController destcontscript;

    GameObject save;
    Save savescript;

    GameObject DB;
    MappingDataBase dbscript;

    GameObject Load;
    LoadController loadscript;

    GameObject TitleBack;
    TitleBack titlebackscript;

    float[] savescale = new float[3];

    float[] eachscale = new float[6];

    // Start is called before the first frame update
    void Start()
    {
        receiver = GameObject.Find("CreateController");
        createscript = receiver.GetComponent<CreateController>();

        DeleteButton = GameObject.Find("DeleteButton");
        Deletescript = DeleteButton.GetComponent<DeleteButton>();

        createBtn = GameObject.Find("CreateButton");
        crebtnscript = createBtn.GetComponent<CreateButton>();

        destroycontroller = GameObject.Find("DestroyController");
        destcontscript = destroycontroller.GetComponent<DestroyController>();

        save = GameObject.Find("SelectSaveData");
        savescript = save.GetComponent<Save>();

        DB = GameObject.Find("DataBaseObject");
        dbscript = DB.GetComponent<MappingDataBase>();

        Load = GameObject.Find("LoadController");
        loadscript = Load.GetComponent<LoadController>();

        TitleBack = GameObject.Find("TileBack");
        titlebackscript = TitleBack.GetComponent<TitleBack>();

        objGet[0] = GameObject.Find("posx+");
        objGet[1] = GameObject.Find("posx-"); 
        objGet[2] = GameObject.Find("posz+");
        objGet[3] = GameObject.Find("posz-");

        objGet[4] = GameObject.Find("roty+");
        objGet[5] = GameObject.Find("roty-");

        createscript.indate();
        wall_num = createscript.createnum + createscript.destroy_num;
        for(int i = 0; i < 6; i++){
            script[i] = objGet[i].GetComponent<MoveScale>();
        }
        if(wall_num < createscript.makelimit){
            if(createscript.creflag[wall_num] == 0){
                crebtnscript.MakeButton();
            }
            //オブジェクトの座標等の計算
            pos[0] = createscript.Scale[wall_num,0] + createscript.Scale[wall_num,1];
            pos[1] = createscript.Scale[wall_num,2] + createscript.Scale[wall_num,3];
            rot = createscript.Scale[wall_num,4] + createscript.Scale[wall_num,5];
        }



        //移動制限
        positionsetting();
        
        for(int i = 0; i < 6; i++)
        {
            eachscale[i] = createscript.Scale[wall_num,i];
        }
        if(createscript.objectnum[wall_num-1] >= 10 && createscript.creflag[wall_num-1] == 0)
        {
            createscript.videonum[wall_num-1] = createscript.moviesnum;
        }else if(createscript.objectnum[wall_num-1] < 9 && createscript.creflag[wall_num-1] == 0){
            createscript.videonum[wall_num-1] = 0;
        }
        Debug.Log("壁番号：" + wall_num);
        Debug.Log("Load時壁型番号：" + createscript.objectnum[wall_num-1]);
        dbscript.UpDateDataBase(wall_num, eachscale[0] ,eachscale[1],eachscale[2], eachscale[3], eachscale[4], eachscale[5] ,loadscript.objectnum, createscript.videonum[wall_num]);
    }

    // Update is called once per frame
    void Update()
    {

        if(wall_num == createscript.move_num)
        {
            //オブジェクトの座標等の計算
            pos[0] = createscript.Scale[wall_num,0] + createscript.Scale[wall_num,1];
            pos[1] = createscript.Scale[wall_num,2] + createscript.Scale[wall_num,3];

            rot = createscript.Scale[wall_num,4] + createscript.Scale[wall_num,5];

            for(int i = 0; i < 6; i++)
            {
                eachscale[i] = createscript.Scale[wall_num,i];
            }

            if(Deletescript.Delete == true)
            {
                DestroyObject();
            }

            //移動制限
            positionsetting();

            savescale[0] = pos[0];
            savescale[1] = pos[1];
            savescale[2] = rot;
        }
        if(destcontscript.numberchange && destcontscript.destroybuttonnum < wall_num)
        {
            wall_num--;
        }
        if(savescript.saving)
        {
            Debug.Log("Save時壁型番号：" + createscript.objectnum[wall_num-1]);
            dbscript.UpDateDataBase(wall_num, eachscale[0] ,eachscale[1],eachscale[2], eachscale[3], eachscale[4], eachscale[5] ,createscript.objectnum[wall_num-1], createscript.videonum[wall_num]);
            if(createscript.createnum == wall_num)
            {
                Debug.Log("データ入れ込み終了");
                savescript.saving = false;
                if(titlebackscript.titleback == true)
                {
                    SceneManager.LoadScene("Title");
                }
            }

        }
    }

    public void DestroyObject()
    {
        //壁の総合計を2つ減らす
        createscript.createnum--;
        //データの初期化
        dbscript.DestroyData(wall_num);
        for(int i = 0; i < 6; i++)
        {
            createscript.Scale[wall_num,i] = 0;
        }
        //オブジェクトの破棄
        Destroy(this.gameObject);
    }

    public void positionsetting()
    {
        if(pos[0] >= -30.0f){ 
            if(pos[0] <= 30.0f){ 
                if(pos[1] >= -30.0f){ 
                    if(pos[1] <= 30.0f){
                        //オブジェクトの移動
                        if(rot == -90){
                            //位置調整
                            pos[0] += 10;
                        }else if(rot == -180){
                            //位置調整
                            pos[0] += 10;
                            pos[1] += 10;
                        }else if(rot == -270){
                            //位置調整
                            pos[1] += 10;
                        }

                        if(rot == 90){
                            //位置調整
                            pos[1] += 10;
                        }else if(rot == 180){
                            //位置調整
                            pos[0] += 10;
                            pos[1] += 10;
                        }else if(rot == 270){
                            //位置調整
                            pos[0] += 10;
                        }
                        this.transform.position = new Vector3(pos[0], 0, pos[1]);
                        angle.eulerAngles = new Vector3(0, rot, 0);
                        transform.rotation = angle;
                    }else{
                        createscript.Scale[wall_num ,0] =   0;
                        createscript.Scale[wall_num ,1] = 30;
                    }
                }else{
                    createscript.Scale[wall_num ,0] = -30;
                    createscript.Scale[wall_num ,1] =  0;
                }
            }else{
                createscript.Scale[wall_num ,0] =  0;
                createscript.Scale[wall_num ,1] = 30;
            }
        }else{
            createscript.Scale[wall_num ,0] = -30;
            createscript.Scale[wall_num ,1] =   0;
        }
    }
}

using UnityEngine;
using System.Collections.Generic;

public class MappingDataBase : MonoBehaviour {

    public SqliteDatabase sqlDB;

    GameObject save;
    Save savescript;

    GameObject Load;
    LoadController loadscript;

    void Start(){

        save = GameObject.Find("SelectSaveData");
        savescript = save.GetComponent<Save>();

        Load = GameObject.Find("LoadController");
        loadscript = Load.GetComponent<LoadController>();


        //データベースにアクセス
　　　　　sqlDB = new SqliteDatabase("mapping.db");
        //Select
　　　　　string query = "SELECT * FROM mapping";
　　　　　var dt = sqlDB.ExecuteQuery(query);
    }

    //データの更新
    public void UpDateDataBase(int makes, float posxp, float posxm, float poszp, float poszm, float rotyp, float rotym, int objnum, int moviesnum)
    {
        // 取得する値: 年
        string datetimeYear = System.DateTime.Now.Year.ToString();  
        // 取得する値: 月
        string datetimeMonth = System.DateTime.Now.Month.ToString();
        // 取得する値: 日
        string datetimeDay = System.DateTime.Now.Day.ToString();
        // 取得する値: 時
        string datetimeHour = System.DateTime.Now.Hour.ToString();
        // 取得する値: 分
        string datetimeMinute = System.DateTime.Now.Minute.ToString();
        // 取得する値: 秒
        string datetimeSecond = System.DateTime.Now.Second.ToString();
        int flag = 1;
        sqlDB = new SqliteDatabase("mapping.db");
        string update = "UPDATE mapping SET positionxp = \'" + (double)posxp + 
                                       "\', positionxm = \'" + (double)posxm + 
                                       "\', positionzp = \'" + (double)poszp + 
                                       "\', positionzm = \'" + (double)poszm + 
                                       "\', rotationyp = \'" + (double)rotyp + 
                                       "\', rotationym = \'" + (double)rotym + 
                                       "\', objectnum =  \'" + objnum + 
                                       "\', credata =  \'" + datetimeYear + "-"+ datetimeMonth + "-" +  datetimeDay + "-" + datetimeHour + "-" + datetimeMinute + "-" + datetimeSecond +
                                       "\', moviesnum = \'" + moviesnum +
                                       "\', createflag = \'" + flag + "\'WHERE makes = \'" + (int)makes + "\' AND savenum = \'" + savescript.saveNum + "\';";
        //Debug.Log(update);
        var dt = sqlDB.ExecuteQuery(update);
    }
    //データの取得
    public void SelectDataBase(int makenum)
    {
        //Select
　　　　　string query = "SELECT * FROM mapping WHERE makes = \'" + makenum + "\' AND savenum = \'" + LoadMove.setSaveData + "\'";
　　　　　var dt = sqlDB.ExecuteQuery(query);

        int savenum;

        //検索
        foreach(DataRow dr in dt.Rows)
        {
            //セーブの番号
            savenum = (int)dr["savenum"];

            //製造番号
            loadscript.makes = (int)dr["makes"];

            //x+座標
            loadscript.positionxp = (double)dr["positionxp"];

            //x-座標
            loadscript.positionxm = (double)dr["positionxm"];

            //z+座標
            loadscript.positionzp = (double)dr["positionzp"];

            //z-座標
            loadscript.positionzm = (double)dr["positionzm"];

            //y+軸の角度
            loadscript.rotationyp = (double)dr["rotationyp"];

            //y-軸の角度
            loadscript.rotationym = (double)dr["rotationym"];

            //壁の種類
            loadscript.objectnum = (int)dr["objectnum"];

            //製造済みかの確認
            loadscript.createflag = (int)dr["createflag"];

            //動画の番号
            loadscript.moviesnum = (int)dr["moviesnum"];
        }
    }

    //データの削除
    public void DestroyData(int makes)
    {
        string delete = "UPDATE mapping SET positionxp = 0 ," + 
                                            "positionxm = 0," +
                                            "positionzp = 0," + 
                                            "positionzm = 0," +
                                            "rotationyp = 0," + 
                                            "rotationym = 0," + 
                                            "objectnum =  0," +
                                            "moviesnum = 0"   + 
                                            "createflag = 0"  +
                                            "WHERE makes = \'" + (int)makes + "\' AND savenum = \'" + savescript.saveNum + "\';";
        var dt = sqlDB.ExecuteQuery(delete);
    }
}

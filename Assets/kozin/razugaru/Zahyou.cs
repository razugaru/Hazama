using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zahyou : MonoBehaviour
{
    //このクラスで加点許可が出たときにほか変数で参照するための変数
    public int Point = 0;
    //撮影を一度きりにするための処理
    public int cnt = 0;
    //男性と女性が一緒にいるときにスコアをプラスするための仮変数
    public int tmpScore = 0;
    //プレイヤーが加点対象と一定距離以内にいるときに撮影した場合プラスする変数
    public int Score = 0;

    //加点対象1とプレイヤーの距離を計測する変数
    public float Hantei1 = 0;
    //加点対象2とプレイヤーの距離を計測する変数
    public float Hantei2 = 0;
    //加点対象3とプレイヤーの距離を計測する変数
    public float Hantei3 = 0;

    // 判定したいオブジェクトのrendererへの参照
    Renderer targetRenderer;

    //Playerを呼ぶ
    public GameObject Player;
    //家(オブジェクト)を呼ぶ
    public GameObject Enemy;
    //メインターゲットを呼ぶ
    public GameObject Enemy2;
    //サブターゲットを呼ぶ
    public GameObject Enemy3;

    void Start()
    {
        //アタッチしたオブジェクトのデータを読み込む処理
        targetRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        //クリックしたときにCamera関数を呼ぶ
        if (Input.GetMouseButton(0))
        {
            Camera();
        }
        // 表示されている場合の処理
        if (targetRenderer.isVisible && cnt == 0)
        {
            Point = 1;
        }
        // 表示されていない場合の処理
        else
        {
            Point = 0;
        }
    }

    //プレイヤーと加点対象との距離を計測する関数
    void Camera()
    {
        /*float _distance = Vector3.Distance(Player.position, transform.position);
        print(_dinstance);*/

        //tmp変数にPlayerオブジェクトの座標を入れる
        Vector3 tmp = GameObject.Find("Player").transform.position;

        //判定で使うのはx座標のみなので、x座標専用の変数Px(Playerのx座標)を用意する
        float Px = tmp.x;

        //Debug.Log(Px);   //Playerの座標を出すもの、いらなければ消して

        //tmp2変数に家(オブジェクト)の座標を入れる
        Vector3 tmp2 = GameObject.Find("Enemy").transform.position;

        //判定で使うのはx座標のみなので、x座標専用の変数Ex(家のx座標)を用意する
        float Ex = tmp2.x;

        //tmp3変数にメインターゲットの座標を入れる
        Vector3 tmp3 = GameObject.Find("Enemy2").transform.position;

        //判定で使うのはx座標のみなので、x座標専用の変数Ex2(メインターゲットのx座標)を用意する
        float Ex2 = tmp3.x;

        //tmp3変数にサブターゲットの座標を入れる
        Vector3 tmp4 = GameObject.Find("Enemy3").transform.position;

        //判定で使うのはx座標のみなので、x座標専用の変数Ex3(サブターゲットのx座標)を用意する
        float Ex3 = tmp4.x;

        //Playerと家の距離を計算
        Hantei1 = Px - Ex;

        //Playerとメインターゲットの距離を計算
        Hantei2 = Px - Ex2;

        //Playerとサブターゲットの距離を計算
        Hantei3 = Px - Ex3;

        //もしも家とPlayerが一定距離以内で撮影されたら
        if (Hantei1 <= 30 && Point == 1)
        {
            //この変数は後に別クラスで得点を計測するときに使う、すでにほかの加点があれば２、なければ１
            if (Score == 1)
            {
                Score = 2;
                cnt = 1;
            }
            else
            {
                Score = 1;
                cnt = 1;
            }
        }

        //もしもメインターゲットとPlayerが一定距離以内で撮影されたら
        if(Hantei2 <= 30 && Point == 1)
        {
            //メインターゲットとサブターゲットは一緒に写って加点なので、片方だけが写っているときは仮の変数に値を入れる
            //片方写っているとtmpScpreは１、両方写っていて２になる
            //以下の処理は、すでにサブターゲットが一緒に写っている場合は２、そうでない場合は１という処理
            if (tmpScore == 1)
            {
                tmpScore = 2;
            }
            else
            {
                tmpScore = 1;
            }
        }

        //もしもサブターゲットとPlayerが一定距離以内で撮影されたら
        //以下の処理は上記したメインターゲットの処理と同様
        if (Hantei3 <= 30 && Point == 1)
        {
            if (tmpScore == 1)
            {
                tmpScore = 2;
            }
            else
            {
                tmpScore = 1;
            }
        }

        //もしもメインターゲットとサブターゲットの両方が写っていたらScoreにプラス１する
        if (tmpScore == 2)
        {
            if (Score == 1)
            {
                Score = 2;
            }
            else
            {
                Score = 1;
            }
        }
    }
}

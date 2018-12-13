using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zahyou : MonoBehaviour
{
    //このクラスで加点許可が出たときにほか変数で参照するための変数
    public int Point1 = 0;
    //加点対象とプレイヤーの距離を計測する変数
    public float Hantei = 0;
    // 判定したいオブジェクトのrendererへの参照
    Renderer targetRenderer;

    public GameObject Player;
    public GameObject Enemy;

    void Start()
    {
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
        if (targetRenderer.isVisible)
        {
            Point1 = 1;
        }
        // 表示されていない場合の処理
        else
        {
            Point1 = 0;
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

        //tmp変数にEnemyオブジェクトの座標を入れる
        Vector3 tmp2 = GameObject.Find("Enemy").transform.position;

        //判定で使うのはx座標のみなので、x座標専用の変数Ex(Enemyのx座標)を用意する
        float Ex = tmp2.x;

        Hantei = Px - Ex;

        if (Hantei <= 30)
        {

            //この変数は後に別クラスで得点を計測するときに使う
            if (Point1 == 1)
            {
                Point1 = 2;
            }
            else
            {
                Point1 = 1;
            }
        }

        //PxとExの座標が両方プラスの値だった時に行う処理
        /*if (Px > 0 && Ex > 0)
        {
            Hantei = Px - Ex;
        }

        //Pxがマイナスの値だった時に行う処理
        else if (Px < 0 && Ex > 0)
        {
            Hantei = Px + Ex;
        }

        //Exがマイナスの値だった時に行う処理
        else if (Ex < 0 && Px < 0)
        {
            Hantei = Ex + Px;
        }

        //PxとExが両方マイナスの値った時に行う処理
        else if (Px < 0 && Ex < 0)
        {
            Hantei = Px - Ex;
        }*/
        //PxとExの距離を出すもの、いらなければ消して
        //Debug.Log(Hantei

        //PxとExの距離が一定以内だった時に加点とみなすための処理

    }
}
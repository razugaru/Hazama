using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    //Zahyouクラスから変数を参照するためのもの
    public Zahyou Zahyou;

    //Scoreを計測するための変数 
    public int Sget1 = 0; 

	void Update () {

        //クリックしたときにZahyouクラスからPoint1変数を参照する。
        if (Input.GetMouseButton(0))   
        {
            Sget1 = Zahyou.Score;
            //Debug.Log(Sget1);   //Sget変数の値を出すもの、いらなければ消して
            
            //Point1の値が1のとき(加点とみなされてる時)に呼び出すもの
            if (Sget1 == 2)
            {
                SceneManager.LoadScene("ResultA");
            }
            else if (Sget1 == 1)
            {
                SceneManager.LoadScene("ResultB");
            }
            else
            {
                SceneManager.LoadScene("ResultC");
            }
        }
    }
}

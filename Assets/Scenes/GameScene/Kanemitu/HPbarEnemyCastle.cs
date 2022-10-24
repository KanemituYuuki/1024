using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI使うときは忘れずに。
using UnityEngine.UI;
public class HPbarEnemyCastle : MonoBehaviour
{
    //Canvasを入れる
    public Canvas canvas;
    //Sliderを入れる
    public Slider slider;

    //最大HPと現在のHP。
    int maxHp = 100;
    int currentHp;

    int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        //CanvasをMain Cameraに向かせる
        canvas.transform.rotation =
            Camera.main.transform.rotation;

        if (Input.GetKey(KeyCode.Space))
        {
            //現在のHPからダメージを引く
            currentHp = currentHp - damage;
        }

        //最大HPにおける現在のHPをSliderに反映。
        //int同士の割り算は小数点以下は0になるので、
        //(float)をつけてfloatの変数として振舞わせる。
        slider.value = (float)currentHp / (float)maxHp;
    }
}

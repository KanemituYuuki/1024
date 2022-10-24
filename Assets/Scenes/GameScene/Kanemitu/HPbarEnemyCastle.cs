using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI�g���Ƃ��͖Y�ꂸ�ɁB
using UnityEngine.UI;
public class HPbarEnemyCastle : MonoBehaviour
{
    //Canvas������
    public Canvas canvas;
    //Slider������
    public Slider slider;

    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 100;
    int currentHp;

    int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 1;
        //���݂�HP���ő�HP�Ɠ����ɁB
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        //Canvas��Main Camera�Ɍ�������
        canvas.transform.rotation =
            Camera.main.transform.rotation;

        if (Input.GetKey(KeyCode.Space))
        {
            //���݂�HP����_���[�W������
            currentHp = currentHp - damage;
        }

        //�ő�HP�ɂ����錻�݂�HP��Slider�ɔ��f�B
        //int���m�̊���Z�͏����_�ȉ���0�ɂȂ�̂ŁA
        //(float)������float�̕ϐ��Ƃ��ĐU���킹��B
        slider.value = (float)currentHp / (float)maxHp;
    }
}

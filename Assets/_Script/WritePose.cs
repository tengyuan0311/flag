//using System;

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using NPinyin;
using Random = UnityEngine.Random;

public class WritePose : MonoBehaviour
{
    public TMP_Text topicCN;
    public TMP_Text topicPY;
    public TextAsset txt;
    public string[] str;
    public Animator modelAnimator;
    public bool leftHand=true;

    private void Start()
    {
        str = txt.text.Split('\n');
        int rand = Random.Range(0, 3);
        topicCN.text = str[rand];
        topicPY.text = NPinyin.Pinyin.GetPinyin(str[rand]);
    }

    public void RightUp()
    {
        if (modelAnimator.GetInteger("左手角度") == 0)
        {
            if (modelAnimator.GetInteger("右手角度") < 4)
            {
                modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")+1);
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 1)
        {
            if (modelAnimator.GetInteger("右手角度") == 2)
            {
                modelAnimator.SetInteger("右手角度",4);
            }
            else if (modelAnimator.GetInteger("右手角度") < 4)
            {
                modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")+1);
            }
        }
    }
    

    public void PoseCheck()
    {
        

    }
    private void Update()
    {
        PoseCheck();
    }
}

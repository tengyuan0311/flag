//using System;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using NPinyin;
using Random = UnityEngine.Random;

public class WritePose : MonoBehaviour
{
    public TMP_Text topicCN;
    public TMP_Text topicPY;
    public TMP_Text inputAns;
    public TextAsset txt;
    public string[] str;
    public string[] character;
    public string currentStr;
    public Animator modelAnimator;
    public StringBuilder ans=new StringBuilder();
    public int idx = 0;
    public string inputPose="abcdefg";
    
    private void Start()
    {
        str = txt.text.Split('\n');
        int rand = Random.Range(0, 3);
        
        currentStr=NPinyin.Pinyin.GetPinyin(str[rand]);
        character = currentStr.Split('/');
        
        topicCN.text = str[rand];
        topicPY.text = NPinyin.Pinyin.GetPinyin(str[rand]);
    }

    public void RightUp()
    {
        if (modelAnimator.GetInteger("左手角度")==0)
        {
            if (modelAnimator.GetInteger("右手角度") < 4)
            {
                 modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")+1);
            }
        }
        
        if (modelAnimator.GetInteger("左手角度")==1)
        {
            if (modelAnimator.GetInteger("右手角度") < 4)
            {
                if (modelAnimator.GetInteger("右手角度") == 2)
                {
                    modelAnimator.SetInteger("右手角度",4);
                }
                else
                {
                    modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")+1);
                }
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 2)
        {
            if (modelAnimator.GetInteger("右手角度") < 6)
            {
                if (modelAnimator.GetInteger("右手角度") == 4)
                {
                    modelAnimator.SetInteger("右手角度",6);
                }
                else
                {
                    modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")+1);
                }
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 3)
        {
            if (modelAnimator.GetInteger("右手角度") < 6)
            {
                modelAnimator.SetInteger("右手角度", modelAnimator.GetInteger("右手角度") + 1);
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 4)
        {
            if (modelAnimator.GetInteger("右手角度") < 4)
            {
                modelAnimator.SetInteger("右手角度", modelAnimator.GetInteger("右手角度") + 1);
            }
        }
        
    }
    public void LeftUp()
    {
        if (modelAnimator.GetInteger("右手角度") == 0)
        {
            if (modelAnimator.GetInteger("左手角度") < 3)
            {
                modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") + 1);
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 1)
        {
            if (modelAnimator.GetInteger("左手角度") < 4)
            {
                modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") + 1);
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 2)
        {
            if (modelAnimator.GetInteger("左手角度") < 6)
            {
                if (modelAnimator.GetInteger("左手角度") == 4)
                {
                    modelAnimator.SetInteger("左手角度", 6);
                }
                else
                {
                    modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") + 1);
                }
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 3)
        {
            if (modelAnimator.GetInteger("左手角度") < 6)
            {
                if (modelAnimator.GetInteger("左手角度") == 0)
                {
                    modelAnimator.SetInteger("左手角度", 2);
                }
                else
                {
                    modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") + 1);
                }
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 4)
        {
            if (modelAnimator.GetInteger("左手角度") < 3)
            {
                modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") + 1);
            }
        }
        
    }
    public void RightDown()
    {
        if (modelAnimator.GetInteger("左手角度")==0)
        {
            if (modelAnimator.GetInteger("右手角度") > 0)
            {
                modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")-1);
            }
        }
        
        if (modelAnimator.GetInteger("左手角度")==1)
        {
            if (modelAnimator.GetInteger("右手角度") > 0)
            {
                if (modelAnimator.GetInteger("右手角度") == 4)
                {
                    modelAnimator.SetInteger("右手角度",2);
                }
                else
                {
                    modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")-1);
                }
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 2)
        {
            if (modelAnimator.GetInteger("右手角度") > 0)
            {
                if (modelAnimator.GetInteger("右手角度") == 6)
                {
                    modelAnimator.SetInteger("右手角度",4);
                }
                else
                {
                    modelAnimator.SetInteger("右手角度",modelAnimator.GetInteger("右手角度")-1);
                }
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 3)
        {
            if (modelAnimator.GetInteger("右手角度") > 0)
            {
                modelAnimator.SetInteger("右手角度", modelAnimator.GetInteger("右手角度") - 1);
            }
        }

        if (modelAnimator.GetInteger("左手角度") == 4)
        {
            if (modelAnimator.GetInteger("右手角度") > 1)
            {
                modelAnimator.SetInteger("右手角度", modelAnimator.GetInteger("右手角度") - 1);
            }
        }
    }
    public void LeftDown()
    {
        if (modelAnimator.GetInteger("右手角度") == 0)
        {
            if (modelAnimator.GetInteger("左手角度") > 0)
            {
                modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") - 1);
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 1)
        {
            if (modelAnimator.GetInteger("左手角度") > 0)
            {
                modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") - 1);
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 2)
        {
            if (modelAnimator.GetInteger("左手角度") > 0)
            {
                if (modelAnimator.GetInteger("左手角度") == 6)
                {
                    modelAnimator.SetInteger("左手角度", 4);
                }
                else
                {
                    modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") - 1);
                }
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 3)
        {
            if (modelAnimator.GetInteger("左手角度") > 0)
            {
                if (modelAnimator.GetInteger("左手角度") == 2)
                {
                    modelAnimator.SetInteger("左手角度", 0);
                }
                else
                {
                    modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") - 1);
                }
            }
        }
        if (modelAnimator.GetInteger("右手角度") == 4)
        {
            if (modelAnimator.GetInteger("左手角度") > 0)
            {
                modelAnimator.SetInteger("左手角度", modelAnimator.GetInteger("左手角度") - 1);
            }
        }
    }

    public void BackToMenu()
    {
        Application.LoadLevel(0);
    }
    public void RightPose(int angle)
    {
        modelAnimator.SetInteger("右手角度",angle);
    }

    public void LeftPose(int angle)
    {
        modelAnimator.SetInteger("左手角度",angle);
    }
    public void EnterPose()
    {
        int l = modelAnimator.GetInteger("左手角度");
        int r = modelAnimator.GetInteger("右手角度");
        if (l == 0 && r == 1)
            ans.Append("a");
        else if (l == 0 && r == 2)
            ans.Append("b");
        else if (l == 0 && r == 3)
            ans.Append("c");
        else if (l == 0 && r == 4)
            ans.Append("d");
        else if (l == 3 && r == 0)
            ans.Append("e");
        else if (l == 2 && r == 0)
            ans.Append("f");
        else if (l == 1 && r == 0)
            ans.Append("g");
        else if (l == 6 && r == 2)
            ans.Append("h");
        else if (l == 6 && r == 3)
            ans.Append("i");
        else if (l == 2 && r == 4)
            ans.Append("j");
        else if (l == 4 && r == 1)
            ans.Append("k");
        else if (l == 3 && r == 1)
            ans.Append("l");
        else if (l == 2 && r == 1)
            ans.Append("m");
        else if (l == 1 && r == 1)
            ans.Append("n");
        else if (l == 5 && r == 3)
            ans.Append("o");
        else if (l == 4 && r == 2)
            ans.Append("p");
        else if (l == 3 && r == 2)
            ans.Append("q");
        else if (l == 2 && r == 2)
            ans.Append("r");
        else if (l == 1 && r == 2)
            ans.Append("s");
        else if (l == 4 && r == 3)
            ans.Append("t");
        else if (l == 3 && r == 3)
            ans.Append("u");
        else if (l == 1 && r == 4)
            ans.Append("v");
        else if (l == 3 && r == 5)
            ans.Append("w");
        else if (l == 0 && r == 6)
            ans.Append("x");
        else if (l == 2 && r == 3)
            ans.Append("y");
        else if (l == 2 && r == 6)
            ans.Append("z");
        else if (l == 3 && r == 4)
            ans.Append("ü");
        else if (l == 4 && r == 4)
            ans.Append("/");
        else if (l == 0 && r == 0)
            ans.Append("/");

    }

    public void DeletePose()
    {
        ans.Remove(ans.Length-1, 1);
    }
    private void Update()
    {
        inputAns.text = ans.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardPose : MonoBehaviour
{
    public Animator modelAnimator;
    public string currentStatename;
    public TMP_Text currentState;
    public void Key2Pose()
    {
        if (Input.GetKeyDown(KeyCode.A))
            modelAnimator.SetInteger("姿势代码",1);
        else if (Input.GetKeyDown(KeyCode.B))
            modelAnimator.SetInteger("姿势代码",2);
        else if (Input.GetKeyDown(KeyCode.C))
            modelAnimator.SetInteger("姿势代码",3);
        else if (Input.GetKeyDown(KeyCode.D))
            modelAnimator.SetInteger("姿势代码",4);
        else if (Input.GetKeyDown(KeyCode.E))
            modelAnimator.SetInteger("姿势代码",5);
        else if (Input.GetKeyDown(KeyCode.F))
            modelAnimator.SetInteger("姿势代码",6);
        else if (Input.GetKeyDown(KeyCode.G))
            modelAnimator.SetInteger("姿势代码",7);
        else if (Input.GetKeyDown(KeyCode.H))
            modelAnimator.SetInteger("姿势代码",8);
        else if (Input.GetKeyDown(KeyCode.I))
            modelAnimator.SetInteger("姿势代码",9);
        else if (Input.GetKeyDown(KeyCode.J))
            modelAnimator.SetInteger("姿势代码",10);
        else if (Input.GetKeyDown(KeyCode.K))
            modelAnimator.SetInteger("姿势代码",11);
        else if (Input.GetKeyDown(KeyCode.L))
            modelAnimator.SetInteger("姿势代码",12);
        else if (Input.GetKeyDown(KeyCode.M))
            modelAnimator.SetInteger("姿势代码",13);
        else if (Input.GetKeyDown(KeyCode.N))
            modelAnimator.SetInteger("姿势代码",14);
        else if (Input.GetKeyDown(KeyCode.O))
            modelAnimator.SetInteger("姿势代码",15);
        else if (Input.GetKeyDown(KeyCode.P))
            modelAnimator.SetInteger("姿势代码",16);
        else if (Input.GetKeyDown(KeyCode.Q))
            modelAnimator.SetInteger("姿势代码",17);
        else if (Input.GetKeyDown(KeyCode.R))
            modelAnimator.SetInteger("姿势代码",18);
        else if (Input.GetKeyDown(KeyCode.S))
            modelAnimator.SetInteger("姿势代码",19);
        else if (Input.GetKeyDown(KeyCode.T))
            modelAnimator.SetInteger("姿势代码",20);
        else if (Input.GetKeyDown(KeyCode.U))
            modelAnimator.SetInteger("姿势代码",21);
        else if (Input.GetKeyDown(KeyCode.Comma))
            modelAnimator.SetInteger("姿势代码",27);
        else if (Input.GetKeyDown(KeyCode.V))
            modelAnimator.SetInteger("姿势代码",22);
        else if (Input.GetKeyDown(KeyCode.W))
            modelAnimator.SetInteger("姿势代码",23);
        else if (Input.GetKeyDown(KeyCode.X))
            modelAnimator.SetInteger("姿势代码",24);
        else if (Input.GetKeyDown(KeyCode.Y))
            modelAnimator.SetInteger("姿势代码",25);
        else if (Input.GetKeyDown(KeyCode.Z))
            modelAnimator.SetInteger("姿势代码",26);
        else if (Input.GetKeyDown(KeyCode.Space))
            modelAnimator.SetInteger("姿势代码",28);
        else
            modelAnimator.SetInteger("姿势代码",0);
    }

    public void ShowCurrentState()
    {
        AnimatorClipInfo[] m_currentClipInfo;
        m_currentClipInfo = this.modelAnimator.GetCurrentAnimatorClipInfo(0);
        currentStatename = m_currentClipInfo[0].clip.name;
        currentState.text = currentStatename;
    }
    void Update()
    {
        Key2Pose();
        ShowCurrentState();
    }
}

/***
 * 
 *    Title: "SUIFW" UI框架项目
 *           主题： xxx       
 *    Description: 
 *          功能：
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

using SUIFW;
using UnityEngine.Windows.Speech;


namespace DemoProject
{
    public class StartProject : BaseUIForms
    {
        void Start()
        {
            //游戏开始
            UIManager.GetInstance().ShowUIForms(SysConst.LogonForms);
        }

    }//Class_end
}
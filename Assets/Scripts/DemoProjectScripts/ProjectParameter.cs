/***
 * 
 *    Title: UI框架项目
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


namespace DemoProject
{
    /// <summary>
    /// UI窗体ID
    /// 功能：标识与简化“窗体预设”
    /// </summary>
    public enum UIFormsID
    {
        LogonForms,
        SelectHeroForms,
        HeroInfo,
        MainForms,
        MarketForms,
        ConfirmForms,
        GoodsInfoForms
    }

    /// <summary>
    /// 消息(监听)的类型
    /// </summary>
    public enum MsgType谢谢谢谢
    {
        MarketInfo,         //商城信息
        PackageInfo,        //背包信息
        PlayerKernalInfo,   //玩家核心信息
        PlayerExternInfo,   //玩家扩展信息
    }

    public class ProjectParameter : MonoBehaviour
    {
        //。。。。
    } //Class_end
}
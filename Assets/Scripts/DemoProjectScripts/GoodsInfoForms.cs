/***
 * 
 *    Title: "SUIFW" UI框架项目
 *           主题：  商品详情。    
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


namespace DemoProject
{
    public class GoodsInfoForms : BaseUIForms
    {
        public Text TxtPropDetailTitle;             //道具详细信息标题
        public Text TxtConfirm;                     //确认
        public Text TxtCancle;                      //取消

        void Awake()
        {
            //本窗体属性
            CurrentUIType.UIForms_Type = UIFormsType.PopUp;
            CurrentUIType.UIForms_ShowMode = UIFormsShowMode.ReverseChange;

            //事件注册
            RigisteButtonObjectEvent("ImgPurchse",
                p => ShowUIForms(UIFormsID.ConfirmForms.ToString())
            );
            RigisteButtonObjectEvent("ImgCancle",
                p => CloseOrReturnUIForms()
            );

            //添加消息监听
            MessageCenter.AddMsgListener(SysConst.MarketInfo,
                p =>
                {
                    if (p.Key.Equals(SysConst.MarketInfo_PropDetailInfo))
                    {
                        if (TxtPropDetailTitle)
                        {
                            TxtPropDetailTitle.text = p.Values.ToString();
                        }
                    }    
                }
                );
        }//Awake_end

        void Start()
        {
            if (TxtConfirm)
            {
                TxtConfirm.text = Show("Confirm");
            }
            if (TxtCancle)
            {
                TxtCancle.text = Show("Cancle");
            }
        }//Start_end

        #region  窗体生命周期
        public override void Display()
        {
            base.Display();
            Log.Write(GetType() + "/Display()");
        }

        public override void Redisplay()
        {
            base.Redisplay();
            Log.Write(GetType() + "/Redisplay()");
        }

        public override void Freeze()
        {
            base.Freeze();
            Log.Write(GetType() + "/Freeze()");
        }

        public override void Hiding()
        {
            base.Hiding();
            Log.Write(GetType() + "/Hiding()");
        }
        #endregion

        
    }//Class_end
}
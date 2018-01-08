/***
 * 
 *    Title: "SUIFW" UI框架项目
 *    
 *           自定义异常： Json解析异常     
 *    Description: 
 *           功能：
 *           专门定位于Json文件解析的异常，如果出现本异常，说明Json格式定义错误。  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System;

namespace SUIFW
{
    public class JsonAnalysisException : Exception
    {
            public JsonAnalysisException() : base() { }
            public JsonAnalysisException(string excptionMessage) : base(excptionMessage) { }
    }
}

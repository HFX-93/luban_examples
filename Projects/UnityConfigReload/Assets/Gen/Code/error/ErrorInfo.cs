//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.error
{

public sealed partial class ErrorInfo :  Bright.Config.BeanBase 
{
    public ErrorInfo(ByteBuf _buf) 
    {
        Code = _buf.ReadString();
        Desc = _buf.ReadString();
        Style = error.ErrorStyle.DeserializeErrorStyle(_buf);
        PostInit();
    }

    public static ErrorInfo DeserializeErrorInfo(ByteBuf _buf)
    {
        return new error.ErrorInfo(_buf);
    }

    public string Code { get; protected set; }
    public string Desc { get; protected set; }
    public error.ErrorStyle Style { get; protected set; }

    public const int __ID__ = 1389347408;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Style?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Style?.TranslateText(translator);
    }

    public void Reload(ErrorInfo reloadData)
    {
        Code = reloadData.Code;
        Desc = reloadData.Desc;
        if(Style==null)
        {
            Style = reloadData.Style;
        }else
        {
            if(Style.GetTypeId() == reloadData.Style.GetTypeId())
            {
                switch (reloadData.Style.GetTypeId())
                {
                    case error.ErrorStyleTip.__ID__:
                        (Style as error.ErrorStyleTip).Reload(reloadData.Style as error.ErrorStyleTip);
                        break;
                    case error.ErrorStyleMsgbox.__ID__:
                        (Style as error.ErrorStyleMsgbox).Reload(reloadData.Style as error.ErrorStyleMsgbox);
                        break;
                    case error.ErrorStyleDlgOk.__ID__:
                        (Style as error.ErrorStyleDlgOk).Reload(reloadData.Style as error.ErrorStyleDlgOk);
                        break;
                    case error.ErrorStyleDlgOkCancel.__ID__:
                        (Style as error.ErrorStyleDlgOkCancel).Reload(reloadData.Style as error.ErrorStyleDlgOkCancel);
                        break;
                }
            }else
            {
                typeof(ErrorInfo).GetProperty("Style").SetValue(this,reloadData.Style);
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Code:" + Code + ","
        + "Desc:" + Desc + ","
        + "Style:" + Style + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}

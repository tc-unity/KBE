using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KBEngine;

public class FirstEntity : FirstEntityBase
{
    public override void __init__()
    {
        base.__init__();
        if (this.isPlayer())
        {
            KBEngine.Event.registerIn("say", this, "Say");
            KBEngine.Event.registerIn("CtreatName", this, "CreatorName");
        }
    }
    public void CreatorName(string _name)
    {
        cellEntityCall.CtreatName(_name);
    }
    public void Say(string content)
    {
        cellEntityCall.say(content);
    }

    public override void onCtreatName()
    {
        Debug.Log("创建用户名！！！");
        KBEngine.Event.fireOut("onCtreatName");
    }

    public override void onEnter(string arg1)
    {
        //Dbg.INFO_MSG("玩家登录到服务器！！！");
        Debug.Log($"玩家 : {arg1} 登录到服务器！！！");
        if (this.isPlayer())
        {
            KBEngine.Event.fireOut("isEnter", arg1);
        }
    }

    public override void onSay(string name, int id, string content)
    {
        Debug.Log($"收到消息！！！ Name : {name},id:{id},content:{content}");
        KBEngine.Event.fireOut("onSay", new object[] { name, content });
    }
}

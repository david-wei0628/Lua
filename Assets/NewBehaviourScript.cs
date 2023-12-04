using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class NewBehaviourScript : MonoBehaviour
{
    LuaEnv luaEnv /*= new LuaEnv()*/;
    LuaEnv luaEnv2 = new LuaEnv();
    [CSharpCallLua]
    public delegate double CallJ();
    // Start is called before the first frame update
    void Start()
    {
        //luaEnv = new LuaEnv();
        //luaEnv.DoString(@"
        //a=15
        //b=a+10
        //print(b-a)
        //");
        luaEnv2.DoString(@"
            function callJ()
                b=1
                a= b
                print(a~=b)
                return a;
            end
        ");
        CallJ callJJ = luaEnv2.Global.Get<CallJ>("callJ");
        var a = callJJ();
        print(a);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            int a = 3 ^ 2;
            print(a);
            luaEnv.DoString(@"
            print(a+b)
            b=b+a
            ");
        }
    }
}

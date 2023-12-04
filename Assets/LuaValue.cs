using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using XLua;
using MoonSharp.Interpreter;

public class LuaValue : MonoBehaviour
{
    LuaEnv luaEnv = new LuaEnv();
    [CSharpCallLua]
    public delegate double CallJ();

    [CSharpCallLua]
    public delegate Vector3 CallV3();

    public GameObject game1;

    public void Atype()
    {
        luaEnv.DoString(@"
            function callJ()
                b=2
                a=b^5
                print(a > b )
                return a
            end
        ");
        CallJ callJJ = luaEnv.Global.Get<CallJ>("callJ");
        var a = callJJ();
    }

    public double Btype()
    {
        luaEnv.DoString(@"
            function callJ()
                b=10
                a=4
                return b^a
            end
        ");
        CallJ callJJ = luaEnv.Global.Get<CallJ>("callJ");
        var a = callJJ();
        a = Mathf.Sqrt((float)a);
        return a;
    }
    //UP Xlua
    //-------
    //DOWN MoonSharp
    public void V3type_oneTest()
    {
        string scriptCode = @"
                function fact (n)
                    if (n == 0) then
                        return 1
                    else
                        return n*fact(n-1)
                    end
                end
                ";
        Script script = new Script();
        script.DoString(scriptCode);
        DynValue luaFactFunction = script.Globals.Get("fact");
        DynValue res = script.Call(luaFactFunction, 6);
        print(res.Number);

    }

    public void V3type_twoTest(Vector3 V3)
    {
        double[] Nv3 = new double[3];
        Nv3[0] = V3.x;
        Nv3[1] = V3.y;
        Nv3[2] = V3.z;

        string scriptCode = @"
                function V3Test (n)

                    return 0
                end
                ";
        Script script = new Script();
        script.DoString(scriptCode);

        DynValue res = script.Call(script.Globals["V3Test"], Nv3);
        print(res.Number);
    }

    public void URLA()
    {
        string directoryPath = $"{Application.streamingAssetsPath}";

        string[] files = Directory.GetFiles(directoryPath);

        for (int i = 0; i < files.Length; i++)
        {
            string path = files[i];
            if (path.EndsWith(".lua.txt") /*|| path.EndsWith(".cs")*/)
            {
                byte[] data = File.ReadAllBytes(path);
                string code = System.Text.Encoding.UTF8.GetString(data);

                Script script = new Script();
                script.DoString(code);
                DynValue res = script.Call(script.Globals.Get("MdefValue"));
                print(res.Number);  
            }
            //{
            //    byte[] data = File.ReadAllBytes(path);print(i + " " + path);
            //    string code = System.Text.Encoding.UTF8.GetString(data);

            //    Script script = new Script();
            //    script.DoString(code);

            //    string name = path.Replace(directoryPath + "\\", "");
            //    scripts.Add(name, script);
            //}
        }

    }
}

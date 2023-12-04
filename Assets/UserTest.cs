using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;
//using MoonSharp.Interpreter;

public class UserTest : MonoBehaviour
{
    [SerializeField]
    LuaValue newLua = new();
        
    public Text V1;
    //[SerializeField]
    //public Script Script = new();
    // Start is called before the first frame update
    void Start()
    {
        newLua = gameObject.GetComponent<LuaValue>();
    }
        
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            newLua.Atype();
        }

        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            var btypevalue = newLua.Btype();
            print(btypevalue+"a");
        }
        
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            ///*var btypevalue = */newLua.V3type(Vector3.zero);
            //newLua.V3type_twoTest(Vector3.one);
            //print(btypevalue);
            newLua.URLA();
            
        }
    }
}

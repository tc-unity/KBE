using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyModle
{
    private static MyModle instance;
    public static MyModle Instance { get
        {
            if (instance==null)
            {
                instance = new MyModle();
            }
            return instance;
        } }


    public string mAccount = "";
    public string mName = "";
}

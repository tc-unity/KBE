using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterPanel : MonoBehaviour
{
    private InputField mAccountInput;
    private InputField mPasswordInput;
    private Button mRegister;
    // Start is called before the first frame update
    void Start()
    {

        mAccountInput = transform.Find("RAccount").GetComponent<InputField>();
        mPasswordInput = transform.Find("RPassword").GetComponent<InputField>();
        mRegister = transform.Find("OnRegister").GetComponent<Button>();
        mRegister.onClick.AddListener(OnClickRegister);
    }

    private void OnClickRegister()
    {
        KBEngine.Event.fireIn(KBEngine.EventInTypes.createAccount, new object[] { mAccountInput.text, mPasswordInput.text, System.Text.Encoding.UTF8.GetBytes("注册！！！") });

        this.gameObject.SetActive(false);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KBEngine;
using UnityEngine.SceneManagement;

public class LoginPanel : MonoBehaviour
{
    private InputField mAccountInput;
    private InputField mPasswordInput;
    private Button mLogin;
    private Button mRegister;

    private RegisterPanel mRegisterPanel;
    private CreatorNamePanel mCreatorNamePanel;

    public Text mTips;
    // Start is called before the first frame update
    void Start()
    {
        KBEngine.Event.registerOut("isEnter", this, "OnEnter");
        KBEngine.Event.registerOut("onCtreatName", this, "OnCtreatName");
        KBEngine.Event.registerOut(KBEngine.EventOutTypes.onLoginFailed, this, "OnLoginFailed");

        mAccountInput = transform.Find("Account").GetComponent<InputField>();
        mPasswordInput = transform.Find("Password").GetComponent<InputField>();
        mLogin = transform.Find("Login").GetComponent<Button>();
        mLogin.onClick.AddListener(OnClickLogin);
        mRegister = transform.Find("Register").GetComponent<Button>();
        mRegister.onClick.AddListener(OnClickRegister);

        mRegisterPanel = FindObjectOfType<RegisterPanel>();
        mCreatorNamePanel = FindObjectOfType<CreatorNamePanel>();
        mRegisterPanel.gameObject.SetActive(false);
        mCreatorNamePanel.gameObject.SetActive(false);
    }

    private void OnClickRegister()
    {
        mRegisterPanel.gameObject.SetActive(true);
    }
    public void OnCtreatName()
    {
        mCreatorNamePanel.gameObject.SetActive(true);
    }
    public void OnEnter(string name)
    {
        MyModle.Instance.mName = name;

        Debug.Log("LoginPanel : OnEnter");
        SceneManager.LoadScene("Main");
    }
    public void OnLoginFailed(UInt16 code, byte[] _serverdatas)
    {
        Debug.Log($"账号登录出错 错误代码:{code}，{KBEngineApp.app.serverErr(code)}");

        Text tip = Instantiate(mTips,this.transform);
        tip.text = KBEngineApp.app.serverErr(code);
        Destroy(tip.gameObject,3);
    }
    private void OnClickLogin()
    {
        KBEngine.Event.fireIn(KBEngine.EventInTypes.login,new object[] { mAccountInput.text, mPasswordInput.text,System.Text.Encoding.UTF8.GetBytes("登录！！！")});

        //MyModle.Instance.mAccount = mAccountInput.text;

    }

}

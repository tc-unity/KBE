using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MianPanel : MonoBehaviour
{
    //private Text mAccount;
    private Text mName;
    private InputField mContentInput;
    private Button mSay;

    public Text mOtherContentPrefab;
    public Text mMyContentPrefab;
    public Transform mContentParent;


    private List<Text> mContentList = new List<Text>();
    // Start is called before the first frame update
    void Start()
    {
        KBEngine.Event.registerOut("onSay",this,"OnSay");

        //mAccount = transform.Find("Account").GetComponent<Text>();
        mName = transform.Find("Name").GetComponent<Text>();
        mName.text = MyModle.Instance.mName;
        mContentInput = transform.Find("InputField").GetComponent<InputField>();
        mSay = transform.Find("Say").GetComponent<Button>();

        mSay.onClick.AddListener(OnClickSay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickSay()
    {
        KBEngine.Event.fireIn("say", new object[] { mContentInput.text});

        Text comtentClone = Instantiate(mMyContentPrefab, mContentParent);
        comtentClone.text = "我： "+mContentInput.text+"  ";
        comtentClone.color = Color.yellow;
        mContentList.Add(comtentClone);
    }
    public void OnSay(string name, string content)
    {
        if (mContentList.Count>10)
        {
            mContentList.RemoveAt(0);
        }

        Text comtentClone = Instantiate(mOtherContentPrefab, mContentParent);
        comtentClone.text = name+": "+content;
        mContentList.Add(comtentClone);
    }
}

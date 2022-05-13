using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatorNamePanel : MonoBehaviour
{
    private InputField mCreatorName;
    private Button mCreator;
    // Start is called before the first frame update
    void Start()
    {
        mCreatorName = transform.Find("CreatorName").GetComponent<InputField>();
        mCreator = transform.Find("Creator").GetComponent<Button>();
        mCreator.onClick.AddListener(OnClickCreator);
    }

    private void OnClickCreator()
    {
        KBEngine.Event.fireIn("CtreatName", new object[] { mCreatorName.text});
        this.transform.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

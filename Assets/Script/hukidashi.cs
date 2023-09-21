using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hukidashi : MonoBehaviour
{
    InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<InputField>();

        InitInputField();
    }
    public void InputLogger()
    {

        string inputValue = inputField.text;

        Debug.Log(inputValue);

        InitInputField();
    }
    void InitInputField()
    {

        // 値をリセット
        inputField.text = "";

        // フォーカス
        inputField.ActivateInputField();
    }


    // Update is called once per frame
    void Update()
    {

    }
}

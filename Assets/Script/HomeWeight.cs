using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeWeight : MonoBehaviour
{
    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputText()
    {
        print(inputField.text);
        MainManager.Instance.Weight = inputField.text;

        if(inputField.text.Length >= 5)
        {
            SceneManager.LoadScene("Home");
        }

    }
}

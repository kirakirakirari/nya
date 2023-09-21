using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weight2 : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = MainManager.Instance.Weight;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

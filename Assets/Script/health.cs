using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("health");
    }
}

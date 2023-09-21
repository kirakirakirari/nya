using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Profile : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Profile");
    }

}

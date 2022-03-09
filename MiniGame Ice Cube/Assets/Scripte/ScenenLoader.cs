using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenenLoader : MonoBehaviour
{
    public void LoadScene(string _scenenName)
    {
        SceneManager.LoadScene(_scenenName);
    }
}

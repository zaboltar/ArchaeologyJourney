using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneMangr : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
    {


        //SceneManager.LoadScene(SceneIndex);
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneIndex);

    }
}

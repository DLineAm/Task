using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateButtonClick : MonoBehaviour
{
    public void OpeneScene()
    {

        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}

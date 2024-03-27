using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
        Debug.Log("Kepanggil 2");
        SceneManager.LoadScene(sceneName);
   }
    
   public void QuitApp()
    {
        Application.Quit();
    }
}

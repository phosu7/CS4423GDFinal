using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string nextScene;
    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene(nextScene);
    }
}

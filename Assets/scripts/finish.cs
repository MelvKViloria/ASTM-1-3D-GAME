using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
 private void OnTriggerEnter(Collider collision) 
 
  
 {
  if (collision.gameObject.CompareTag("Finish"))
  {
    SceneManager.LoadScene(0);
    Application.Quit(); 
  }
 }
}

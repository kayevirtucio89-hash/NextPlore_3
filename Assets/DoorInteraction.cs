using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public string sceneToLoad = "D1F2"; // Palitan mo ng actual scene name

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

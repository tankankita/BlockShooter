using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript_Lab : MonoBehaviour
{
    public GameObject fpsController;
    public GameObject screenCanvas;
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        fpsController.SetActive(false);
        screenCanvas.SetActive(false);
        mainCamera.SetActive(true);
    }

    // Update is called once per frame
    public void StartGame()
    {
        fpsController.SetActive(true);
        screenCanvas.SetActive(true);
        mainCamera.SetActive(false);
        gameObject.SetActive(false);
    }
}

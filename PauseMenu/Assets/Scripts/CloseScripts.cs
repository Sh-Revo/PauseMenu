using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseScripts : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        _closeButton.onClick.AddListener(OnCloseButtonHandler);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCloseButtonHandler()
    {
        Debug.Log("[OnCloseButtonHandler] OK");
        pauseMenu.SetActive(false);
    }
}

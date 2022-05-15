using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogPressButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(OnPressButtonHandler);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPressButtonHandler()
    {
        Debug.Log("[OnPressButtonHandler] OK, " + _button.name);
    }
}

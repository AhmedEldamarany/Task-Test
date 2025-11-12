using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Switcher : MonoBehaviour{
    public Image switchImage;
    public TMP_Text switchState;
    public Button switchButton;
    private bool isOn = true;

    private void OnEnable() {
        switchButton.onClick.AddListener(SwitchState);
    }

    private void OnDisable() {
        switchButton.onClick.RemoveListener(SwitchState);
    }

    private void SwitchState() {
        if (isOn){
            switchImage.color = Color.green;
            switchState.text = "ON";
        }
        else{
            switchImage.color = Color.red;
            switchState.text = "OFF";
        }

        isOn = !isOn;
    }
}
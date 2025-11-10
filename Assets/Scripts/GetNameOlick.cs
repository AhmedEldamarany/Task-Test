using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetNameOlick : MonoBehaviour{
    public Button joinButton;
    public TMP_InputField nameField;
    string playerName;
    private void OnEnable() {
        joinButton.onClick.AddListener(SaveName);
    }

    private void OnDisable() {
        joinButton.onClick.RemoveListener(SaveName);
    }

    private void SaveName() {
        playerName = nameField.text;
        Debug.Log(playerName);
    }
}

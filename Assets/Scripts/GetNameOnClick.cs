using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GetNameOnClick : MonoBehaviour{
    public Button joinButton;
    public TMP_InputField nameField;
    private string playerName;
    [FormerlySerializedAs("playerNameSO")] public PlayerNameSO playerNameSo;
    private void OnEnable() {
        joinButton.onClick.AddListener(SaveName);
    }

    private void OnDisable() {
        joinButton.onClick.RemoveListener(SaveName);
    }

    private void SaveName() {
        playerName = nameField.text;
        playerNameSo.playerName = playerName;
        Debug.Log(playerName);
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GetNameOnClick : MonoBehaviour{
    public Button joinButton;
    public TMP_InputField nameField;
    public GameObject warningMessage;
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
        if (string.IsNullOrEmpty(playerName)){
            warningMessage.SetActive(true);
            return;
        }
        playerNameSo.playerName = playerName;
        // better use an event system and a spearate class for scene transition
        SceneManager.LoadScene(1);
        Debug.Log(playerName);
    }
}
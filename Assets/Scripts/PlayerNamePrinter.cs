using TMPro;
using UnityEngine;

public class PlayerNamePrinter : MonoBehaviour{
    public TMP_Text connectingMessage;
    public PlayerNameSO playerNameSo;
   
    void Start()
    {
        if (playerNameSo == null) return;
        connectingMessage.text = $"Connected as {playerNameSo.playerName}";
        Debug.Log($"Player {playerNameSo.playerName} Joined the Room");
    }
}

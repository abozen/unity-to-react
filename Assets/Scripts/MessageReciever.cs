using UnityEngine;
using TMPro;

public class MessageReceiver : MonoBehaviour
{
    public TextMeshProUGUI textField; // Inspector'dan atayın
    
    // JS'den çağrılacak metod
    public void ReceiveMessage(string message)
    {
        if (textField != null)
        {
            textField.text = message;
            Debug.Log("React'ten mesaj alındı: " + message);
        }
        else
        {
            Debug.LogError("Text field atanmamış!");
        }
    }
}
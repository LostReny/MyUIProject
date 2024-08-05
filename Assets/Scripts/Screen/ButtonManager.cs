using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button myButton; // Arraste o botão da hierarquia para esta variável no Inspector

    void Start()
    {
        if (myButton != null)
        {
            // Configura o método para ser chamado quando o botão for clicado
            myButton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogWarning("Botão não atribuído. Arraste o botão para a variável 'myButton' no Inspector.");
        }
    }

    void OnButtonClick()
    {
        Debug.Log("O botão foi clicado!");
        // Adicione a lógica que você deseja executar quando o botão for clicado
    }
}

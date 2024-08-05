using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;

public class Typer : MonoBehaviour
{
    // Efeito de digitação aparecendo uma letra por vez
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = 0.1f; // Defina um valor padrão

    public string myPhrase = "Texto de exemplo"; // Defina um valor padrão

    private void Awake()
    {
        if (textMesh == null)
        {
            Debug.LogError("TextMeshProUGUI não está atribuído.");
            return;
        }

        textMesh.text = "";
    }

    [NaughtyAttributes.Button]
    public void StartType()
    {
        if (string.IsNullOrEmpty(myPhrase))
        {
            Debug.LogWarning("A frase está vazia.");
            return;
        }

        StartCoroutine(Type(myPhrase));
    }

    private IEnumerator Type(string s)
    {
        textMesh.text = ""; // Limpar texto atual
        foreach (char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }
}

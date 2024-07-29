using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;

public class Typer : MonoBehaviour
{
   //efeito de digitação aparecendo uma tecla por vez

    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters; 

    public string myPhrase;


    private void Awake()
    {
        textMesh.text = "";
    }


    [NaughtyAttributes.Button]
    public void StartType()
    {
        StartCoroutine(Type(myPhrase));
    }


   IEnumerator Type(string s)
   {
    
    textMesh.text = "";
    foreach(char l in s.ToCharArray())
    {
        textMesh.text += l;
        yield return new WaitForSeconds(timeBetweenLetters);
    }

   }
}

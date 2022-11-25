using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomWords : MonoBehaviour
{
    public WordListSO wordList;
    public int wordAmount = 10;

    [Space]
    public StringEvent OnGenerateWords;

    public void Generate() {
        string[] list = wordList.GetList();
        string txt = "";
        for (int i = 0; i < wordAmount; i++) {
            txt += list[Random.Range(0, list.Length - 1)] + " ";
        }

        OnGenerateWords?.Invoke(txt);
    }

    private void Start() {
        Generate();
    }
}

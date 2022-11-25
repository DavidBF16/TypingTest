using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WordListSO", menuName = "SO/WordList")]
public class WordListSO : ScriptableObject{
    [SerializeField] string language = "en";
    [TextArea(3, 20)]
    [SerializeField] string word;

    public string GetLanguage() => language;
    public string[] GetList() => word.Split(' ');
    public string GetWords() => word;
}

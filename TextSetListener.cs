using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(TMPro.TMP_Text))]
public class TextSetListener : KeyActionListener<string>{
    public override void UpdateValue(string value)
    { 
        GetComponent<TMPro.TMP_Text>().text = value;
    }
}

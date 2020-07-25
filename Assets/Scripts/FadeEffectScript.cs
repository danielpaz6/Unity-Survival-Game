using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class FadeEffectScript : MonoBehaviour
{
    public Text InstructionText;
    private Color color;
    public float fadeSpeed = 5;
    public bool enterance = false;
    void Start()
    {
       color = InstructionText.color;
       InstructionText.color = Color.white;
    }
    void Update()
    {
        ColorChange();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") enterance = true;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player") enterance = false;
    }
    private void ColorChange()
    {
        if (enterance)
            InstructionText.color = Color.Lerp(InstructionText.color, color, fadeSpeed * Time.deltaTime);
        if (!enterance)
            InstructionText.color = Color.Lerp(InstructionText.color, Color.clear, fadeSpeed * Time.deltaTime);
    }
}

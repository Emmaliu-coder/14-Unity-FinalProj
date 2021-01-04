using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class InputSystem : MonoBehaviour
{
    public TMP_Text  gt;
    public string ct;
    // 開門Rrrrr

    void Start()
    {
        gt = GetComponent<TMP_Text>();
    }

    void Update()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (gt.text.Length != 0)
                {
                    gt.text = gt.text.Substring(0, gt.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                print("User entered their name: " + gt.text);
                // if (gt.text == ct)
                {
                    // 補個正確和錯誤題示
                    

                }
            }
            else
            {
                gt.text += c;
            }
        }
    }
}
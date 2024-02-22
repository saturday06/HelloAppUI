using Unity.AppUI.UI;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class HelloAppUI : MonoBehaviour
{
    // 起動時に一時だけ実行されるメソッド
    void Start()
    {
        // "Hello AppUI!" などと表示し、OKボタンを押すと消えるダイアログを作る
        var dialog = new AlertDialog
        {
            title = "Hello",
            description = "Hello AppUI!",
            variant = AlertSemantic.Information
        };
        dialog.SetPrimaryAction(1, "OK", () => Debug.Log("OK"));

        // UXMLに記載したパネルを一つ取得
        var panel = GetComponent<UIDocument>().rootVisualElement.Q<Panel>();
        // ↑で作ったダイアログを、パネルの上に表示
        Modal.Build(panel, dialog).Show();
    }
}

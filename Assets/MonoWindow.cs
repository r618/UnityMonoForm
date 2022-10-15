using System.Windows.Forms;
using UnityEngine;

[ExecuteInEditMode]
public class MonoWindow : MonoBehaviour
{
    Form form;
    void OnGUI()
    {
        if (GUILayout.Button("MonoForm"))
        {
            this.form = new MonoForm();
            this.form.Show();
        }
    }
}

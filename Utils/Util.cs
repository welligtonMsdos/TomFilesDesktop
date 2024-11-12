using System.Windows.Forms;

namespace TomFilesDesktop.Utils;

public static class Util
{
    public static void ClearFields(Control T, ref int id)
    {
        id = 0;

        foreach (Control control in T.Controls)
        {
            if (control is TextBox textBox)
                textBox.Clear();
            else if (control.Controls.Count > 0)
                ClearFields(control, ref id);
        }
    }

    public static void MsgInformation(string msg)
    {
        MessageBox.Show(msg, "Tom File", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void MsgError(string msg)
    {
        MessageBox.Show(msg, "Tom File", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static bool MsgQuestion(string msg)
    {
        if (MessageBox.Show(msg, "Tom File",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No) return false;

        return true;
    }
}


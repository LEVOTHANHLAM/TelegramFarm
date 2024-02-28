using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class FormHelper
{
	
    public static void ShowFormWithoutTaskbar(Form form)
    {
        try
        {
            form.ShowInTaskbar = false;
            form.ShowDialog();
        }
        catch
        {
        }
    }
    public static string DecodeBase64ToString(string string_0)
    {
        byte[] bytes = Convert.FromBase64String(string_0);
        return Encoding.UTF8.GetString(bytes);
    }
    public static List<string> RemoveEmptyStrings(List<string> list_0)
    {
        List<string> list = new List<string>();
        string text = "";
        for (int i = 0; i < list_0.Count; i++)
        {
            text = list_0[i].Trim();
            if (text != "")
            {
                list.Add(text);
            }
        }
        return list;
    }
}

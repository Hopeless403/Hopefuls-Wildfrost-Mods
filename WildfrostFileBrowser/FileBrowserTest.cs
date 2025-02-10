using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using AnotherFileBrowser.Windows;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class FileBrowserTest : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    /// <summary>
    /// FileDialog for picking a single file
    /// </summary>
    public void OpenFileBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "txt files (*.txt)|*.txt";
        bp.filterIndex = 0;

        new FileBrowser().OpenFileBrowser(bp, result =>
        {
            resultText.text = result;
            Debug.Log(result);
        });
    }

    /// <summary>
    /// FileDialog for picking multiple file(s)
    /// </summary>
    public void OpenMultiSelectBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
        bp.filterIndex = 0;

        new FileBrowser().OpenMultiSelectFileBrowser(bp, result =>
        {
            if (result == null) return;
            string s = "";
            for (int i = 0; i < result.Length; i++)
            {
                s += result[i] + "\n";
            }
            resultText.text = s;
        });
    }

    /// <summary>
    /// FileDialog for selecting any folder
    /// </summary>
    public void OpenFolderBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "txt files (*.txt)|*.txt";
        bp.filterIndex = 0;

        new FileBrowser().OpenFolderBrowser(bp, result =>
        {
            resultText.text = result;
            Debug.Log(result);
        });
    }

    /// <summary>
    /// FileDialog for saving any file, returns path with extention for further uses
    /// </summary>
    public void SaveFileBrowser()
    {
        var bp = new BrowserProperties();
        bp.filter = "txt files (*.txt)|*.txt";
        bp.filterIndex = 0;

        new FileBrowser().SaveFileBrowser(bp, "test", ".txt", result =>
        {
            resultText.text = result;
            Debug.Log(result);
        });
    }
}

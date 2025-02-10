using HarmonyLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityExplorer.ObjectExplorer;
using UnityExplorer.Runtime;
using UnityExplorer.UI.Panels;
using UnityExplorer.UI;
using UnityExplorer;
using UniverseLib.Config;
using UniverseLib.Input;
using UniverseLib;

namespace CardEditor;
public static class CardEditorCore
{
    public const string NAME = "CardEditor";

    public const string VERSION = "1.0.0";

    public const string AUTHOR = "Hope";

    public const string GUID = "hope.wildfrost.CardEditor";

    public const string DEFAULT_EXPLORER_FOLDER_NAME = "hope-dev-CardEditor";

    public static IExplorerLoader Loader { get; private set; }

    public static string ExplorerFolder => Path.Combine(Loader.ExplorerFolderDestination, Loader.ExplorerFolderName);

    public static Harmony Harmony => CardEditorMod.instance?.HarmonyInstance;


    public static void Init(IExplorerLoader loader)
    {
        if (Loader != null)
        {
            throw new Exception("UnityExplorer is already loaded.");
        }

        Loader = loader;
        Log("UnityExplorer 4.9.0 initializing...");
        Directory.CreateDirectory(ExplorerFolder);
        UnityExplorer.Config.ConfigManager.Init(Loader.ConfigHandler);
        Universe.Init(UnityExplorer.Config.ConfigManager.Startup_Delay_Time.Value, LateInit, Log, new UniverseLibConfig
        {
            Disable_EventSystem_Override = UnityExplorer.Config.ConfigManager.Disable_EventSystem_Override.Value,
            Force_Unlock_Mouse = UnityExplorer.Config.ConfigManager.Force_Unlock_Mouse.Value,
            Unhollowed_Modules_Folder = loader.UnhollowedModulesFolder
        });
        UERuntimeHelper.Init();
        ExplorerBehaviour.Setup();
        UnityCrashPrevention.Init();
    }

    private static void LateInit()
    {
        SceneHandler.Init();
        Log("Creating UI...");
        UIManager.InitUI();
        Log(string.Format("{0} {1} ({2}) initialized.", "UnityExplorer", "4.9.0", Universe.Context));
    }

    internal static void Update()
    {
        if (InputManager.GetKeyDown(UnityExplorer.Config.ConfigManager.Master_Toggle.Value))
        {
            UIManager.ShowMenu = !UIManager.ShowMenu;
        }
    }

    public static void Log(object message)
    {
        Log(message, LogType.Log);
    }

    public static void LogWarning(object message)
    {
        Log(message, LogType.Warning);
    }

    public static void LogError(object message)
    {
        Log(message, LogType.Error);
    }

    public static void LogUnity(object message, LogType logType)
    {
        if (UnityExplorer.Config.ConfigManager.Log_Unity_Debug.Value)
        {
            Log($"[Unity] {message}", logType);
        }
    }

    private static void Log(object message, LogType logType)
    {
        string text = message?.ToString() ?? "";
        LogPanel.Log(text, logType);
        switch (logType)
        {
            case LogType.Assert:
            case LogType.Log:
                Loader.OnLogMessage(text);
                break;
            case LogType.Warning:
                Loader.OnLogWarning(text);
                break;
            case LogType.Error:
            case LogType.Exception:
                Loader.OnLogError(text);
                break;
        }
    }

    public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
    {
        Directory.CreateDirectory(target.FullName);
        FileInfo[] files = source.GetFiles();
        foreach (FileInfo fileInfo in files)
        {
            fileInfo.MoveTo(Path.Combine(target.ToString(), fileInfo.Name));
        }

        DirectoryInfo[] directories = source.GetDirectories();
        foreach (DirectoryInfo directoryInfo in directories)
        {
            DirectoryInfo target2 = target.CreateSubdirectory(directoryInfo.Name);
            CopyAll(directoryInfo, target2);
        }
    }
}

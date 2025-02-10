using CardEditor.UI.Panels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Text;
using UniverseLib.UI;
using UniverseLib.UI.Models;
using UniverseLib.UI.Panels;

namespace CardEditor.UI;
public static class UIManager
{
    public enum Panels
    {
        ObjectExplorer,
        Inspector,
        CSConsole,
        Options,
        ConsoleLog,
        AutoCompleter,
        UIInspectorResults,
        HookManager,
        Clipboard,
        Freecam
    }

    public enum VerticalAnchor
    {
        Top,
        Bottom
    }

    public static VerticalAnchor NavbarAnchor = VerticalAnchor.Top;

    internal static readonly Dictionary<Panels, CEPanel> UIPanels = new Dictionary<Panels, CEPanel>();

    public static RectTransform NavBarRect;

    public static GameObject NavbarTabButtonHolder;

    private static readonly Vector2 NAVBAR_DIMENSIONS = new Vector2(1020f, 35f);

    private static ButtonRef closeBtn;

    //private static TimeScaleWidget timeScaleWidget;

    private static int lastScreenWidth;

    private static int lastScreenHeight;

    public static bool Initializing { get; internal set; } = true;


    internal static UIBase UiBase { get; private set; }

    public static GameObject UIRoot
    {
        get
        {
            UIBase uiBase = UiBase;
            return (uiBase != null) ? uiBase.RootObject : null;
        }
    }

    public static RectTransform UIRootRect { get; private set; }

    public static Canvas UICanvas { get; private set; }

    public static bool ShowMenu
    {
        get
        {
            return UiBase != null && UiBase.Enabled;
        }
        set
        {
            if (UiBase != null && UIRoot && UiBase.Enabled != value)
            {
                //UniversalUI.SetUIActive("com.sinai.unityexplorer", value);
                //UniversalUI.SetUIActive(MouseInspector.UIBaseGUID, value);
            }
        }
    }

    internal static void InitUI()
    {
        //UiBase = (UIBase)(object)UniversalUI.RegisterUI<ExplorerUIBase>("com.sinai.unityexplorer", (Action)Update);
        UIRootRect = UIRoot.GetComponent<RectTransform>();
        UICanvas = UIRoot.GetComponent<Canvas>();
        /*DisplayManager.Init();
        Display activeDisplay = DisplayManager.ActiveDisplay;
        lastScreenWidth = activeDisplay.renderingWidth;
        lastScreenHeight = activeDisplay.renderingHeight;*/
        CreateTopNavBar();
        /*UIPanels.Add(Panels.AutoCompleter, new AutoCompleteModal(UiBase));
        UIPanels.Add(Panels.ObjectExplorer, new ObjectExplorerPanel(UiBase));
        UIPanels.Add(Panels.Inspector, new InspectorPanel(UiBase));
        UIPanels.Add(Panels.CSConsole, new CSConsolePanel(UiBase));
        UIPanels.Add(Panels.HookManager, new HookManagerPanel(UiBase));
        UIPanels.Add(Panels.Freecam, new FreeCamPanel(UiBase));
        UIPanels.Add(Panels.Clipboard, new ClipboardPanel(UiBase));
        UIPanels.Add(Panels.ConsoleLog, new LogPanel(UiBase));
        UIPanels.Add(Panels.Options, new OptionsPanel(UiBase));
        UIPanels.Add(Panels.UIInspectorResults, new MouseInspectorResultsPanel(UiBase));*/
        /*MouseInspector.inspectorUIBase = UniversalUI.RegisterUI(MouseInspector.UIBaseGUID, (Action)null);
        new MouseInspector(MouseInspector.inspectorUIBase);
        Notification.Init();
        ConsoleController.Init();*/
        Dropdown[] componentsInChildren = UIRoot.GetComponentsInChildren<Dropdown>(includeInactive: true);
        foreach (Dropdown dropdown in componentsInChildren)
        {
            dropdown.RefreshShownValue();
        }

        Initializing = false;
        /*if (ConfigManager.Hide_On_Startup.Value)
        {
            ShowMenu = false;
        }*/
    }

    public static void Update()
    {
        /*if (UIRoot && !MouseInspector.Instance.TryUpdate())
        {
            Notification.Update();
            if (InputManager.GetKeyDown(ConfigManager.Force_Unlock_Toggle.Value))
            {
                ConfigManager.Force_Unlock_Mouse = !ConfigManager.Force_Unlock_Mouse;
            }

            timeScaleWidget.Update();
            Display activeDisplay = DisplayManager.ActiveDisplay;
            if (activeDisplay.renderingWidth != lastScreenWidth || activeDisplay.renderingHeight != lastScreenHeight)
            {
                OnScreenDimensionsChanged();
            }
        }*/
    }

    public static CEPanel GetPanel(Panels panel)
    {
        return UIPanels[panel];
    }

    public static T GetPanel<T>(Panels panel) where T : CEPanel
    {
        return (T)UIPanels[panel];
    }

    public static void TogglePanel(Panels panel)
    {
        CEPanel panel2 = GetPanel(panel);
        SetPanelActive(panel, !((UIModel)panel2).Enabled);
    }

    public static void SetPanelActive(Panels panelType, bool active)
    {
        ((UIModel)GetPanel(panelType)).SetActive(active);
    }

    public static void SetPanelActive(CEPanel panel, bool active)
    {
        ((UIModel)panel).SetActive(active);
    }

    public static void SetNavBarAnchor()
    {
        switch (NavbarAnchor)
        {
            case VerticalAnchor.Top:
                NavBarRect.anchorMin = new Vector2(0.5f, 1f);
                NavBarRect.anchorMax = new Vector2(0.5f, 1f);
                NavBarRect.anchoredPosition = new Vector2(NavBarRect.anchoredPosition.x, 0f);
                NavBarRect.sizeDelta = NAVBAR_DIMENSIONS;
                break;
            case VerticalAnchor.Bottom:
                NavBarRect.anchorMin = new Vector2(0.5f, 0f);
                NavBarRect.anchorMax = new Vector2(0.5f, 0f);
                NavBarRect.anchoredPosition = new Vector2(NavBarRect.anchoredPosition.x, 35f);
                NavBarRect.sizeDelta = NAVBAR_DIMENSIONS;
                break;
        }
    }

    private static void OnScreenDimensionsChanged()
    {
        /*Display activeDisplay = DisplayManager.ActiveDisplay;
        lastScreenWidth = activeDisplay.renderingWidth;
        lastScreenHeight = activeDisplay.renderingHeight;*/
        foreach (KeyValuePair<Panels, CEPanel> uIPanel in UIPanels)
        {
            ((PanelBase)uIPanel.Value).EnsureValidSize();
            ((PanelBase)uIPanel.Value).EnsureValidPosition();
            ((PanelBase)uIPanel.Value).Dragger.OnEndResize();
        }
    }

    private static void OnCloseButtonClicked()
    {
        ShowMenu = false;
    }

    private static void Master_Toggle_OnValueChanged(KeyCode val)
    {
        closeBtn.ButtonText.text = val.ToString();
    }

    private static void CreateTopNavBar()
    {
        GameObject gameObject = UIFactory.CreateUIObject("MainNavbar", UIRoot, default(Vector2));
        UIFactory.SetLayoutGroup<HorizontalLayoutGroup>(gameObject, (bool?)false, (bool?)false, (bool?)true, (bool?)true, (int?)5, (int?)4, (int?)4, (int?)4, (int?)4, (TextAnchor?)TextAnchor.MiddleCenter);
        gameObject.AddComponent<Image>().color = new Color(0.1f, 0.1f, 0.1f);
        NavBarRect = gameObject.GetComponent<RectTransform>();
        NavBarRect.pivot = new Vector2(0.5f, 1f);
        //NavbarAnchor = ConfigManager.Main_Navbar_Anchor.Value;
        SetNavBarAnchor();
        //ConfigElement<VerticalAnchor> main_Navbar_Anchor = ConfigManager.Main_Navbar_Anchor;
        /*main_Navbar_Anchor.OnValueChanged = (Action<VerticalAnchor>)Delegate.Combine(main_Navbar_Anchor.OnValueChanged, (Action<VerticalAnchor>)delegate (VerticalAnchor val)
        {
            NavbarAnchor = val;
            SetNavBarAnchor();
        });*/
        string text = "UE <i><color=grey>4.9.0</color></i>";
        UnityEngine.UI.Text text2 = UIFactory.CreateLabel(gameObject, "Title", text, TextAnchor.MiddleCenter, default(Color), true, 14);
        GameObject gameObject2 = text2.gameObject;
        int? num = 75;
        int? num2 = 0;
        UIFactory.SetLayoutElement(gameObject2, num, (int?)null, num2, (int?)null, (int?)null, (int?)null, (bool?)null);
        NavbarTabButtonHolder = UIFactory.CreateUIObject("NavTabButtonHolder", gameObject, default(Vector2));
        GameObject navbarTabButtonHolder = NavbarTabButtonHolder;
        num2 = 25;
        int? num3 = 999;
        int? num4 = 999;
        UIFactory.SetLayoutElement(navbarTabButtonHolder, (int?)null, num2, num4, num3, (int?)null, (int?)null, (bool?)null);
        UIFactory.SetLayoutGroup<HorizontalLayoutGroup>(NavbarTabButtonHolder, (bool?)false, (bool?)true, (bool?)true, (bool?)true, (int?)4, (int?)2, (int?)2, (int?)2, (int?)2, (TextAnchor?)null);
        //timeScaleWidget = new TimeScaleWidget(gameObject);
        GameObject gameObject3 = UIFactory.CreateUIObject("Spacer", gameObject, default(Vector2));
        UIFactory.SetLayoutElement(gameObject3, (int?)15, (int?)null, (int?)null, (int?)null, (int?)null, (int?)null, (bool?)null);
        //closeBtn = UIFactory.CreateButton(gameObject, "CloseButton", ConfigManager.Master_Toggle.Value.ToString(), (Color?)null);
        //GameObject gameObject4 = closeBtn.Component.gameObject;
        num4 = 25;
        //UIFactory.SetLayoutElement(gameObject4, (int?)60, num4, (int?)0, (int?)null, (int?)null, (int?)null, (bool?)null);
        //RuntimeHelper.SetColorBlock((Selectable)closeBtn.Component, (Color?)new Color(0.63f, 0.32f, 0.31f), (Color?)new Color(0.81f, 0.25f, 0.2f), (Color?)new Color(0.6f, 0.18f, 0.16f), (Color?)null);
        //ConfigElement<KeyCode> master_Toggle = ConfigManager.Master_Toggle;
        //master_Toggle.OnValueChanged = (Action<KeyCode>)Delegate.Combine(master_Toggle.OnValueChanged, new Action<KeyCode>(Master_Toggle_OnValueChanged));
        ButtonRef obj = closeBtn;
        obj.OnClick = (Action)Delegate.Combine(obj.OnClick, new Action(OnCloseButtonClicked));
    }
}
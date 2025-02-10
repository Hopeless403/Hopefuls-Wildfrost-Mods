using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


//using UnityExplorer.UI;
using UniverseLib.UI;
using UniverseLib.UI.Models;
using UniverseLib.UI.Panels;

namespace CardEditor.UI.Panels;
public abstract class CEPanel : PanelBase
{
    private bool setDefault = false;

    public abstract UIManager.Panels PanelType { get; }

    public virtual bool ShowByDefault => false;

    public virtual bool ShouldSaveActiveState => true;

    public virtual bool NavButtonWanted => true;

    public ButtonRef NavButton { get; internal set; }

    public bool ApplyingSaveData { get; set; }

    protected CEPanel(UIBase owner)
        : base(owner)
    {
    }

    /*protected override PanelDragger CreatePanelDragger()
    {
        return (PanelDragger)(object)new UEPanelDragger((PanelBase)(object)this);
    }*/

    /*public override void OnFinishDrag()
    {
        ((PanelBase)this).OnFinishDrag();
        SaveInternalData();
    }

    public override void OnFinishResize()
    {
        ((PanelBase)this).OnFinishResize();
        SaveInternalData();
    }*/

    /*public override void SetActive(bool active)
    {
        if (Enabled != active)
        {
            ((PanelBase)this).SetActive(active);
            if (!ApplyingSaveData)
            {
                SaveInternalData();
            }

            if (NavButtonWanted && NavButton != null)
            {
                Color color = (active ? UniversalUI.EnabledButtonColor : UniversalUI.DisabledButtonColor);
                RuntimeHelper.SetColorBlock((Selectable)NavButton.Component, (Color?)color, (Color?)(color * 1.2f), (Color?)null, (Color?)null);
            }
        }

        if (!active)
        {
            if (Dragger != null)
            {
                Dragger.WasDragging = false;
            }
        }
        else
        {
            UIRoot.transform.SetAsLastSibling();
            (Owner.Panels as UEPanelManager).DoInvokeOnPanelsReordered();
        }
    }*/

    public override void SetDefaultSizeAndPosition()
    {
        if (!setDefault)
        {
            setDefault = true;
            ((PanelBase)this).SetDefaultSizeAndPosition();
        }
    }

    /*public void SaveInternalData()
    {
        if (!UIManager.Initializing && !ApplyingSaveData)
        {
            SetSaveDataToConfigValue();
        }
    }*/

    /*private void SetSaveDataToConfigValue()
    {
        ConfigManager.GetPanelSaveData(PanelType).Value = ToSaveData();
    }*/

    /*public virtual string ToSaveData()
    {
        try
        {
            return string.Join("|", $"{ShouldSaveActiveState && Enabled}", Rect.RectAnchorsToString(), Rect.RectPositionToString());
        }
        catch (Exception arg)
        {
            ExplorerCore.LogWarning($"Exception generating Panel save data: {arg}");
            return "";
        }
    }*/

    /*public virtual void ApplySaveData()
    {
        string value = ConfigManager.GetPanelSaveData(PanelType).Value;
        ApplySaveData(value);
    }*/

    /*protected virtual void ApplySaveData(string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            return;
        }

        string[] array = data.Split('|');
        try
        {
            Rect.SetAnchorsFromString(array[1]);
            Rect.SetPositionFromString(array[2]);
            EnsureValidSize();
            EnsureValidPosition();
            SetActive(bool.Parse(array[0]));
        }
        catch
        {
            ExplorerCore.LogWarning("Invalid or corrupt panel save data! Restoring to default.");
            SetDefaultSizeAndPosition();
            SetSaveDataToConfigValue();
        }
    }*/

    public override void ConstructUI()
    {
        ((PanelBase)this).ConstructUI();
        if (NavButtonWanted)
        {
            NavButton = UIFactory.CreateButton(UIManager.NavbarTabButtonHolder, $"Button_{PanelType}", Name, null);
            GameObject gameObject = NavButton.Component.gameObject;
            gameObject.AddComponent<ContentSizeFitter>().horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
            UIFactory.SetLayoutGroup<HorizontalLayoutGroup>(gameObject, false, true, true, true, 0, 0, 0, 5, 5, TextAnchor.MiddleCenter);
            UIFactory.SetLayoutElement(gameObject, 80, null, null, null, null, null, null);
            //RuntimeHelper.SetColorBlock((Selectable)NavButton.Component, (Color?)UniversalUI.DisabledButtonColor, (Color?)(UniversalUI.DisabledButtonColor * 1.2f), null, null);
            ButtonRef navButton = NavButton;
            navButton.OnClick = (Action)Delegate.Combine(navButton.OnClick, (Action)delegate
            {
                UIManager.TogglePanel(PanelType);
            });
            GameObject gameObject2 = gameObject.transform.Find("Text").gameObject;
            gameObject2.AddComponent<ContentSizeFitter>().horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }

        SetActive(true);
        SetActive(false);
        SetActive(ShowByDefault);
    }

    protected override void LateConstructUI()
    {
        ApplyingSaveData = true;
        base.LateConstructUI();
        /*try
        {
            ApplySaveData();
        }
        catch (Exception arg)
        {
            ExplorerCore.Log($"Exception loading panel save data: {arg}");
            SetDefaultSizeAndPosition();
        }*/

        /*OnToggleEnabled += delegate
        {
            SaveInternalData();
        };*/
        ApplyingSaveData = false;
        Dragger.OnEndResize();
    }
}

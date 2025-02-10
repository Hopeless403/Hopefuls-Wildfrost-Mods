// Decompiled with JetBrains decompiler
// Type: GainUnlockSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class GainUnlockSequence : MonoBehaviour
{
  public TMP_Text titleElement;
  public TMP_Text descriptionElement;
  [Header("Displays")]
  [SerializeField]
  public GameObject constructionDisplay;
  [SerializeField]
  public GameObject petHutDisplay;
  [SerializeField]
  public GameObject inventorDisplay;
  [SerializeField]
  public GameObject icebreakerDisplay;
  [SerializeField]
  public GameObject tribeHallDisplay;
  [SerializeField]
  public GameObject hotSpringDisplay;
  [SerializeField]
  public GameObject frostoscopeDisplay;
  [SerializeField]
  public GameObject challengeShrineDisplay;
  [SerializeField]
  public GameObject newItemIcon;
  public GameObject display;

  public void SetUp(UnlockData unlockData)
  {
    this.SetTitle(unlockData);
    this.SetDisplay(unlockData);
    this.SetDescription(unlockData);
    this.gameObject.SetActive(true);
  }

  public void SetTitle(UnlockData unlockData)
  {
    string str = string.Empty;
    if ((Object) unlockData.relatedBuilding != (Object) null && unlockData.relatedBuilding.titleKey != null)
      str = str + "<size=7.5>" + unlockData.relatedBuilding.titleKey.GetLocalizedString() + "</size>";
    if (unlockData.unlockTitle != null)
    {
      if (!str.IsNullOrWhitespace())
        str += "\n";
      str = str + "<#C3967F>" + unlockData.unlockTitle.GetLocalizedString();
    }
    this.titleElement.text = str;
  }

  public void SetDisplay(UnlockData unlockData)
  {
    this.newItemIcon.SetActive(unlockData.type == UnlockData.Type.Item || unlockData.type == UnlockData.Type.Pet || unlockData.type == UnlockData.Type.Tribe);
    if ((Object) this.display != (Object) null)
      this.display.SetActive(false);
    if (unlockData.type == UnlockData.Type.BuildingStarted)
    {
      this.SetDisplay(this.constructionDisplay);
    }
    else
    {
      string name = unlockData.relatedBuilding.name;
      // ISSUE: reference to a compiler-generated method
      switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(name))
      {
        case 274784770:
          if (!(name == "Frostoscope"))
            break;
          this.SetDisplay(this.frostoscopeDisplay);
          break;
        case 492444653:
          if (!(name == "InventorHut"))
            break;
          this.SetDisplay(this.inventorDisplay);
          break;
        case 1110305817:
          if (!(name == "ChallengeShrine"))
            break;
          this.SetDisplay(this.challengeShrineDisplay);
          break;
        case 1471324901:
          if (!(name == "Icebreakers"))
            break;
          this.SetDisplay(this.icebreakerDisplay);
          break;
        case 1949646385:
          if (!(name == "HotSpring"))
            break;
          this.SetDisplay(this.hotSpringDisplay);
          break;
        case 2945460819:
          if (!(name == "PetHut"))
            break;
          this.SetDisplay(this.petHutDisplay);
          break;
        case 4143207400:
          if (!(name == "TribeHut"))
            break;
          this.SetDisplay(this.tribeHallDisplay);
          break;
      }
    }
  }

  public void SetDisplay(GameObject type)
  {
    this.display = type;
    this.display.SetActive(true);
  }

  public void SetDescription(UnlockData unlockData)
  {
    LocalizedString unlockDesc = unlockData.unlockDesc;
    if (unlockDesc != null && !unlockDesc.IsEmpty)
      this.descriptionElement.text = unlockData.unlockDesc.GetLocalizedString();
    else
      this.descriptionElement.text = "";
  }

  public void Close() => this.gameObject.SetActive(false);
}

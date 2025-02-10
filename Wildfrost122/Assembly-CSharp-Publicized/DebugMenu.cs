// Decompiled with JetBrains decompiler
// Type: DebugMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;

#nullable disable
public class DebugMenu : MonoBehaviour
{
  [SerializeField]
  public GameObject menu;
  [SerializeField]
  public float holdTime = 2f;
  [SerializeField]
  public TMP_Text resultText;
  public float currentHoldTime;
  public bool active;

  public void Update()
  {
    if (this.active)
      return;
    if (DebugMenu.CheckMouse() || DebugMenu.CheckController())
    {
      this.currentHoldTime += Time.unscaledDeltaTime;
      if ((double) this.currentHoldTime <= (double) this.holdTime)
        return;
      this.Activate();
    }
    else
      this.currentHoldTime = 0.0f;
  }

  public static bool CheckMouse()
  {
    if (!MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return false;
    return Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse2);
  }

  public static bool CheckController()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return false;
    if (InputSystem.IsButtonHeld("Backpack") && InputSystem.IsButtonHeld("Redraw Bell"))
      return true;
    return InputSystem.IsButtonHeld("Up") && InputSystem.IsButtonHeld("Down");
  }

  public void Activate()
  {
    this.active = true;
    this.menu.gameObject.SetActive(true);
    this.resultText.text = "";
  }

  public void Deactivate()
  {
    this.active = false;
    this.menu.gameObject.SetActive(false);
  }

  public void DeleteSave()
  {
    int num = SaveSystem.LoadProgressData<int>("tutorialProgress", 0);
    string str = SaveSystem.LoadProgressData<string>("version", "0");
    SaveSystem.DeleteProgress();
    SaveSystem.DeleteCampaign(AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal"));
    SaveSystem.SaveProgressData<int>("tutorialProgress", num);
    SaveSystem.SaveProgressData<string>("version", str);
    this.resultText.text = "Save Data Deleted!";
  }

  public void ResetTutorial()
  {
    SaveSystem.DeleteProgressData("tutorialProgress");
    this.resultText.text = "Tutorial Reset!";
  }

  public void RunCommand(string command)
  {
    Routine routine = new Routine(Console.HandleCommand(command));
    this.resultText.text = command;
  }
}

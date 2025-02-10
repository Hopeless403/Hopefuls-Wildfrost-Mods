// Decompiled with JetBrains decompiler
// Type: BattleLogEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Threading.Tasks;
using TMPro;
using UnityEngine;

#nullable disable
public class BattleLogEntry : MonoBehaviour
{
  [SerializeField]
  private TMP_Text textElement;
  private const string colorFriendly = "5E849A";
  private const string colorEnemy = "804248";
  private const string colorNumber = "EE5D46";

  public async Task SetUp(BattleLog log)
  {
    this.textElement.text = BattleLogEntry.FormatLogText(BattleLogEntry.AddInserts(await log.textKey.GetLocalizedStringAsync().Task, log.args));
  }

  private static string AddInserts(string text, object[] inserts)
  {
    if (inserts != null && inserts.Length != 0)
    {
      object[] objArray = new object[inserts.Length];
      for (int index = 0; index < inserts.Length; ++index)
      {
        object insert = inserts[index];
        if (insert is BattleEntity entity)
        {
          string entityName = BattleLogEntry.GetEntityName(entity);
          string str = entity.friendly ? "5E849A" : "804248";
          objArray[index] = (object) ("<#" + str + ">" + entityName + "</color>");
        }
        else
          objArray[index] = insert;
      }
      text = string.Format(text, objArray);
    }
    return text;
  }

  private static string GetEntityName(BattleEntity entity)
  {
    string str = entity.forceTitle;
    if (str.IsNullOrWhitespace())
      str = entity.titleKey.GetLocalizedString();
    return str;
  }

  private static string FormatLogText(string text)
  {
    int startIndex = text.IndexOf('[');
    if (startIndex >= 0)
    {
      int num = text.IndexOf(']');
      if (num >= startIndex + 2)
      {
        string str = text.Substring(startIndex + 1, num - startIndex - 1);
        text = text.Remove(startIndex, num - startIndex + 1);
        text = text.Insert(startIndex, "<#EE5D46>" + str + "</color>");
        text = BattleLogEntry.FormatLogText(text);
      }
    }
    return text;
  }
}

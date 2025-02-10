// Decompiled with JetBrains decompiler
// Type: Snowfall2.Util.TextTools
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System.Text.RegularExpressions;

namespace Snowfall2.Util
{
  public static class TextTools
  {
    public static string ReplaceEffectText(string replaceText, int amount)
    {
      replaceText = Regex.Replace(replaceText, "\\{ap[0-9]+\\}", (MatchEvaluator) (match => (int.Parse(match.Value.Substring(3, match.Length - 4)) + amount).ToString()));
      return replaceText;
    }
  }
}

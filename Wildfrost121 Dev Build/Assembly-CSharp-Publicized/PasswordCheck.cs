// Decompiled with JetBrains decompiler
// Type: PasswordCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Linq;

#nullable disable
public static class PasswordCheck
{
  public static PasswordCheck.PasswordStrength GetPasswordStrength(string password)
  {
    int passwordStrength = 0;
    if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password.Trim()))
      return PasswordCheck.PasswordStrength.Blank;
    if (PasswordCheck.HasMinimumLength(password, 5))
      ++passwordStrength;
    if (PasswordCheck.HasMinimumLength(password, 8))
      ++passwordStrength;
    if (PasswordCheck.HasUpperCaseLetter(password) && PasswordCheck.HasLowerCaseLetter(password))
      ++passwordStrength;
    if (PasswordCheck.HasDigit(password))
      ++passwordStrength;
    if (PasswordCheck.HasSpecialChar(password))
      ++passwordStrength;
    return (PasswordCheck.PasswordStrength) passwordStrength;
  }

  public static bool IsStrongPassword(string password)
  {
    if (!PasswordCheck.HasMinimumLength(password, 8) || !PasswordCheck.HasUpperCaseLetter(password) || !PasswordCheck.HasLowerCaseLetter(password))
      return false;
    return PasswordCheck.HasDigit(password) || PasswordCheck.HasSpecialChar(password);
  }

  public static bool IsValidPassword(string password, PasswordCheck.PasswordOptions opts)
  {
    return PasswordCheck.IsValidPassword(password, opts.RequiredLength, opts.RequiredUniqueChars, opts.RequireNonAlphanumeric, opts.RequireLowercase, opts.RequireUppercase, opts.RequireDigit);
  }

  public static bool IsValidPassword(
    string password,
    int requiredLength,
    int requiredUniqueChars,
    bool requireNonAlphanumeric,
    bool requireLowercase,
    bool requireUppercase,
    bool requireDigit)
  {
    return PasswordCheck.HasMinimumLength(password, requiredLength) && PasswordCheck.HasMinimumUniqueChars(password, requiredUniqueChars) && (!requireNonAlphanumeric || PasswordCheck.HasSpecialChar(password)) && (!requireLowercase || PasswordCheck.HasLowerCaseLetter(password)) && (!requireUppercase || PasswordCheck.HasUpperCaseLetter(password)) && (!requireDigit || PasswordCheck.HasDigit(password));
  }

  public static bool HasMinimumLength(string password, int minLength)
  {
    return password.Length >= minLength;
  }

  public static bool HasMinimumUniqueChars(string password, int minUniqueChars)
  {
    return password.Distinct<char>().Count<char>() >= minUniqueChars;
  }

  public static bool HasDigit(string password)
  {
    return password.Any<char>((Func<char, bool>) (c => char.IsDigit(c)));
  }

  public static bool HasSpecialChar(string password)
  {
    return password.IndexOfAny("!@#$%^&*?_~-£().,".ToCharArray()) != -1;
  }

  public static bool HasUpperCaseLetter(string password)
  {
    return password.Any<char>((Func<char, bool>) (c => char.IsUpper(c)));
  }

  public static bool HasLowerCaseLetter(string password)
  {
    return password.Any<char>((Func<char, bool>) (c => char.IsLower(c)));
  }

  public enum PasswordStrength
  {
    Blank,
    VeryWeak,
    Weak,
    Medium,
    Strong,
    VeryStrong,
  }

  public struct PasswordOptions
  {
    public int RequiredLength;
    public int RequiredUniqueChars;
    public bool RequireNonAlphanumeric;
    public bool RequireLowercase;
    public bool RequireUppercase;
    public bool RequireDigit;
  }
}

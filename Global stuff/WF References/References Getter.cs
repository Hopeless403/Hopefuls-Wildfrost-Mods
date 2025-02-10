using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod.WF_References;
public enum CardNames
{
    BoBo
}
public enum CardTitles
{

}

public class Cards
{
    public enum ClunkerNames
    {

    }
    public enum BossNames
    {

    }
    public enum MiniBosses
    {

    }
    public enum Enemies
    {

    }
    public enum Companions
    {

    }
    public enum Pets
    {

    }
    public enum Shades
    {

    }
    public enum Items
    {

    }
}
public class ReferencesGetter : WildfrostMod
{
    public static ReferencesGetter Mod;
    public ReferencesGetter(string modDirectory) : base(modDirectory) { Mod = this; }
    public override string GUID => "hope.wildfrost.references";
    public override string[] Depends => new string[] { };
    public override string Title => "References Generator";
    public override string Description => "";

    public override void Load()
    {
        base.Load();
        
    }
}
public static class Extensions
{
    public static string ToTitle(this CardNames t)
    {
        return t.ToString();
    }
}

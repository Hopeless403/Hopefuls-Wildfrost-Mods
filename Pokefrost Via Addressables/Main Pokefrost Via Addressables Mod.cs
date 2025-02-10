using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.U2D;
using UnityEngine.UI;

public static class CardHelpers
{
    public static CardDataBuilder SetAddressableSprites(this CardDataBuilder builder, string mainSpriteName, string backgroundSpriteName)
    {
        Sprite mainSprite = MyMod.Cards.GetSprite(mainSpriteName.Replace(".png", ""));
        Sprite backgroundSprite = MyMod.Cards.GetSprite(backgroundSpriteName.Replace(".png", ""));
        return builder.SetSprites(mainSprite, backgroundSprite);
    }
}



[HarmonyPatch]
public partial class MyMod : WildfrostMod
{
    // it should be named this to show up as a Singleton in UnityExplorer
    public static MyMod instance;
    public MyMod(string modDirectory) : base(modDirectory)
    {
        instance = this;
    }
    public override string GUID => "hope.wildfrost.pokefrostviaaddressables";
    public override string[] Depends => new string[] { };
    public override string Title => "Pokefrost Via Addressables";
    public override string Description => $"Last update: {DateTime.Now}";
    public override TMP_SpriteAsset SpriteAsset => base.SpriteAsset;
    public static GameObject behaviour;
    public static Transform prefabParent;

    public static string CatalogFolder => Path.Combine(instance.ModDirectory, "Windows");
    public static string CatalogPath => Path.Combine(CatalogFolder, "catalog.json");

    [HarmonyPatch(typeof(CardDataBuilder), nameof(CardDataBuilder.SetSprites), typeof(string), typeof(string))]
    public static bool Prefix(ref CardDataBuilder __result, CardDataBuilder __instance, string mainSprite, string backgroundSprite)
    {
        if (__instance.Mod != instance)
            return true;

        //Sprite main = Addressables.LoadAssetAsync<Sprite>("Pokefrost/Images/" + mainSprite).WaitForCompletion();
        //Sprite background = Addressables.LoadAssetAsync<Sprite>("Pokefrost/Images/" + backgroundSprite).WaitForCompletion();
        Sprite main = Cards.GetSprite(Path.GetFileNameWithoutExtension(mainSprite));
        Sprite background = Cards.GetSprite(Path.GetFileNameWithoutExtension(backgroundSprite));
        if (!main || !background)
            return true;
        
        __result = __instance.SetSprites(main, background);
        Debug.LogWarning("SUCCESS");
        return false;
    }

    [HarmonyPatch(typeof(CardUpgradeDataBuilder), nameof(CardUpgradeDataBuilder.WithImage), typeof(string))]
    public static bool Prefix(ref CardUpgradeDataBuilder __result, CardUpgradeDataBuilder __instance, string img)
    {
        if (__instance.Mod != instance)
            return true;

        
        Sprite main = instance.GetAsset<Sprite>("Pokefrost/Images/" + img);
        __result = __instance.WithImage(main);
        return false;
    }

    public static IResourceLocator locator;

    public static SpriteAtlas Cards;
    public static SpriteAtlas UI;
    public override void Load()
    {
        if (!Addressables.ResourceLocators.Any(r => r is ResourceLocationMap map && map.LocatorId == CatalogPath))
        {
            Addressables.LoadContentCatalogAsync(CatalogPath).WaitForCompletion();
        }

        Task<UnityEngine.Object> task = Addressables.LoadAssetAsync<UnityEngine.Object>($"Assets/{GUID}/Cards.spriteatlas").Task;
        UI = Addressables.LoadAssetAsync<SpriteAtlas>($"Assets/hope.wildfrost.mymod/UI.spriteatlas").WaitForCompletion();

        Task.WhenAll(task).Wait();

        object at;
        StopWatch.Start();
        Debug.LogWarning(at = Addressables.LoadAssetAsync<UnityEngine.Object>("Pokefrost/Sprite Atlas.spriteatlas").WaitForCompletion());
        if (at is SpriteAtlas atl)
        {
            Debug.LogError("FOUND " + (Cards = atl));
        }
        StopWatch.Stop();
        Debug.LogError("LOADING TOOK " + StopWatch.Milliseconds);
        assets = [];
        CreateModAssetsCards();
        CreateModAssetsCharms();
        base.Load();


        behaviour = new GameObject(Title);
        GameObject.DontDestroyOnLoad(behaviour);
        behaviour.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                              HideFlags.HideInInspector | HideFlags.NotEditable;

    }


    public override void Unload()
    {
        base.Unload();
        GameObject.Destroy(behaviour);
        behaviour = null;
    }

    public void Log(object message) => Debug.Log($"[{Title}] {message}");
    public void LogWarning(object message) => Debug.LogWarning($"[{Title} Warning] {message}");
    public void LogError(object message) => Debug.LogError($"[{Title} Error] {message}");

    public static List<object> assets = new List<object>();
    public override List<T> AddAssets<T, Y>()
    {
        if (assets.OfType<T>().Any())
            this.Log($"adding {typeof(Y).Name}s: {assets.OfType<T>().Select(a => a._data.name).Join()}");
        return assets.OfType<T>().ToList();
    }
    private void CreateModAssetsCards()
    {
        Debug.Log("[Pokefrost] Loading Cards");
        //Add our cards here
        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("alolansandslash", "Alolan Sandslash", bloodProfile: "Blood Profile Snow")
                .SetStats(6, 5, 4)
                .SetSprites("alolansandslash.png", "alolansandslashBG.png")
                .AddPool("SnowUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("meowth", "Meowth")
                .SetStats(4, 3, 3)
                .SetSprites("meowth.png", "meowthBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("persian", "Persian")
                .SetStats(7, 0, 4)
                .SetSprites("persian.png", "persianBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("machoke", "Machoke")
                .SetStats(8, 3, 5)
                .SetSprites("machoke.png", "machokeBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("machamp", "Machamp")
                .SetStats(8, 3, 5)
                .SetSprites("machamp.png", "machampBG.png")
            );
        new StatusEffectInstantKill();
        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("sylveon", "Sylveon")
                .SetStats(10, null, 3)
                .SetAddressableSprites("sylveon", "sylveonBG.png") // ".png" doesn't matter anymore
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("slowbro", "Slowbro")
                .SetStats(10, 1, 5)
                .SetSprites("slowbro.png", "slowbroBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("magneton", "Magneton", idleAnim: "FloatAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(3, 0, 3)
                .SetSprites("magneton.png", "magnetonBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("farfetchd", "Farfetch'd")
                .SetStats(4, 6, 3)
                .SetSprites("farfetchd.png", "farfetchdBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("muk", "Muk")
                .SetStats(7, 0, 5)
                .SetSprites("muk.png", "mukBG.png")
                .AddPool("MagicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("haunter", "Haunter")
                .SetStats(8, 2, 3)
                .SetSprites("haunter.png", "haunterBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("gengar", "Gengar")
                .SetStats(8, 3, 3)
                .SetSprites("gengar.png", "gengarBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("voltorb", "Voltorb", idleAnim: "PulseAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(4, null, 2)
                .SetSprites("voltorb.png", "voltorbBG.png")
                .WithValue(50)
                .AddPool("GeneralItemPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("electrode", "Electrode", idleAnim: "PulseAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(6, null, 2)
                .SetSprites("electrode.png", "electrodeBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("cubone", "Cubone")
                .SetStats(4, 2, 4)
                .SetSprites("cubone.png", "cuboneBG.png")
                .AddPool("MagicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("marowak", "Marowak")
                .SetStats(4, 2, 4)
                .SetSprites("marowak.png", "marowakBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("alolanmarowak", "Alolan Marowak", bloodProfile: "Blood Profile Husk")
                .SetStats(4, null, 0)
                .SetSprites("alolanmarowak.png", "alolanmarowakBG.png")
            );

        /*assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hitmonlee", "Hitmonlee")
                .SetStats(5, 5, 5)
                .SetSprites("hitmonlee.png", "hitmonleeBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hitmonchan", "Hitmonchan")
                .SetStats(5, 5, 5)
                .SetSprites("hitmonchan.png", "hitmonchanBG.png")
            );*/

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("lickitung", "Lickitung", bloodProfile: "Blood Profile Berry")
                .SetStats(7, 3, 3)
                .SetSprites("lickitung.png", "lickitungBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("weezing", "Weezing", idleAnim: "FloatAnimationProfile", bloodProfile: "Blood Profile Husk")
                .SetStats(8, 2, 3)
                .SetSprites("weezing.png", "weezingBG.png")
                .AddPool("ClunkUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("seadra", "Seadra", idleAnim: "FloatAnimationProfile")
                .SetStats(7, 5, 5)
                .SetSprites("seadra.png", "seadraBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("magikarp", "Magikarp", idleAnim: "ShakeAnimationProfile")
                .SetStats(1, 0, 4)
                .SetSprites("magikarp.png", "magikarpBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("gyarados", "Gyarados", idleAnim: "GiantAnimationProfile")
                .SetStats(8, 4, 4)
                .SetSprites("gyarados.png", "gyaradosBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("eevee", "Eevee")
                .SetStats(4, 3, 3)
                .SetSprites("eevee.png", "eeveeBG.png")
                .IsPet((ChallengeData)null, true)
                .WithFlavour("Despite the limitless possibilities, Eevee is already perfect")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("vaporeon", "Vaporeon", bloodProfile: "Blood Profile Blue (x2)")
                .SetStats(4, 3, 3)
                .SetSprites("vaporeon.png", "vaporeonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("jolteon", "Jolteon")
                .SetStats(4, 3, 3)
                .SetSprites("jolteon.png", "jolteonBG.png")
                .STraits(("Draw", 1))
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("flareon", "Flareon")
                .SetStats(4, 2, 3)
                .SetSprites("flareon.png", "flareonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("snorlax", "Snorlax", idleAnim: "SquishAnimationProfile")
                .SetStats(10, 6, 5)
                .SetSprites("snorlax.png", "snorlaxBG.png")
            );

        /*assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("porygon", "Porygon")
                .SetStats(5, 5, 5)
                .SetSprites("porygon.png", "porygonBG.png")
            );*/

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("furret", "Furret")
                .SetStats(5, 2, 5)
                .SetSprites("furret.png", "furretBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("natu", "Natu")
                .SetStats(4, 1, 4)
                .SetSprites("natu.png", "natuBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("xatu", "Xatu")
                .SetStats(8, 3, 4)
                .SetSprites("xatu.png", "xatuBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("aipom", "Aipom")
                .SetStats(6, 3, 3)
                .SetSprites("aipom.png", "aipomBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("espeon", "Espeon")
                .SetStats(4, 3, 3)
                .SetSprites("espeon.png", "espeonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("umbreon", "Umbreon")
                .SetStats(8, 1, 3)
                .SetSprites("umbreon.png", "umbreonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("murkrow", "Murkrow")
                .SetStats(7, 4, 4)
                .SetSprites("murkrow.png", "murkrowBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("slowking", "Slowking")
                .SetStats(10, null, 5)
                .SetSprites("slowking.png", "slowkingBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("sneasel", "Sneasel", idleAnim: "PingAnimationProfile")
                .SetStats(6, 0, 2)
                .SetSprites("sneasel.png", "sneaselBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hisuiansneasel", "Hitsuian Sneasel", idleAnim: "PingAnimationProfile")
                .SetStats(6, 0, 3)
                .SetSprites("hisuiansneasel.png", "hisuiansneaselBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("magcargo", "Magcargo", idleAnim: "GoopAnimationProfile")
                .SetStats(15, 0, 6)
                .SetSprites("magcargo.png", "magcargoBG.png")
                .AddPool("BasicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("kingdra", "Kingdra")
                .SetStats(9, 3, 5)
                .SetSprites("kingdra.png", "kingdraBG.png")
            );

        /*assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("porygon2", "Porygon2")
                .SetStats(5, 5, 5)
                .SetSprites("porygon2.png", "porygon2BG.png")
            );*/

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("smeargle", "Smeargle")
                .SetStats(1, 1, 4)
                .SetSprites("smeargle.png", "smeargleBG.png")
                .AddPool()
            );

        /*assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("tyrogue", "Tyrogue")
                .SetStats(5, 5, 5)
                .SetSprites("tyrogue.png", "tyrogueBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hitmontop", "Hitmontop")
                .SetStats(5, 5, 5)
                .SetSprites("hitmontop.png", "hitmontopBG.png")
            );*/

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("raikou", "Raikou")
                .SetStats(9, 0, 4)
                .SetSprites("raikou.png", "raikouBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("entei", "Entei")
                .SetStats(8, 0, 3)
                .SetSprites("entei.png", "enteiBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("suicune", "Suicune")
                .SetStats(8, 0, 3)
                .SetSprites("suicune.png", "suicuneBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hooh", "Ho-Oh")
                .WithCardType("Leader")
                .SetStats(8, 0, 3)
                .SetSprites("hooh.png", "hoohBG.png")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("ludicolo", "Ludicolo")
                .SetStats(10, 4, 0)
                .SetSprites("ludicolo.png", "ludicoloBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("kirlia", "Kirlia")
                .SetStats(4, 2, 4)
                .SetSprites("kirlia.png", "kirliaBG.png")
                .AddPool("BasicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("gardevoir", "Gardevoir")
                .SetStats(5, 5, 5)
                .SetSprites("gardevoir.png", "gardevoirBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("nincada", "Nincada", idleAnim: "PingAnimationProfile", bloodProfile: "Blood Profile Fungus")
                .SetStats(6, 2, 4)
                .SetSprites("nincada.png", "nincadaBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("ninjask", "Ninjask", idleAnim: "FlyAnimationProfile", bloodProfile: "Blood Profile Fungus")
                .SetStats(6, 2, 4)
                .SetSprites("ninjask.png", "ninjaskBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("shedinja", "Shedinja", idleAnim: "FloatAnimationProfile", bloodProfile: "Blood Profile Husk")
                .WithCardType("Summoned")
                .SetStats(1, 2, 4)
                .SetSprites("shedinja.png", "shedinjaBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("makuhita", "Makuhita")
                .SetStats(6, 0, 4)
                .SetSprites("makuhita.png", "makuhitaBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hariyama", "Hariyama", idleAnim: "GiantAnimationProfile")
                .SetStats(12, 0, 4)
                .SetSprites("hariyama.png", "hariyamaBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("nosepass", "Nosepass", bloodProfile: "Blood Profile Husk")
                .SetStats(8, 4, 4)
                .SetSprites("nosepass.png", "nosepassBG.png")
                .WithFlavour("My magnetic field attracts tons of charms from the sidelines")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("sableye", "Sableye", bloodProfile: "Blood Profile Pink Wisp")
                .SetStats(10, 0, 2)
                .SetSprites("sableye.png", "sableyeBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("aron", "Aron")
                .SetStats(4, 6, 4)
                .SetSprites("aron.png", "aronBG.png")
                .AddPool("ClunkUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("lairon", "Lairon")
                .SetStats(6, 6, 4)
                .SetSprites("lairon.png", "laironBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("aggron", "Aggron")
                .SetStats(8, 6, 4)
                .SetSprites("aggron.png", "aggronBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("carvanha", "Carvanha", idleAnim: "FloatAnimationProfile")
                .SetStats(6, 3, 4)
                .SetSprites("carvanha.png", "carvanhaBG.png")
                .AddPool("MagicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("sharpedo", "Sharpedo", idleAnim: "FloatAnimationProfile")
                .SetStats(7, 3, 4)
                .SetSprites("sharpedo.png", "sharpedoBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("spinda", "Spinda", idleAnim: "Heartbeat2AnimationProfile")
                .SetStats(5, 4, 4)
                .SetSprites("spinda.png", "spindaBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("cradily", "Cradily", idleAnim: "GoopAnimationProfile", bloodProfile: "Blood Profile Fungus")
                .SetStats(12, null, 5)
                .SetSprites("cradily.png", "cradilyBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("duskull", "Duskull", idleAnim: "FloatAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(8, null, 0)
                .SetSprites("duskull.png", "duskullBG.png")
                .AddPool("MagicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("dusclops", "Dusclops", bloodProfile: "Blood Profile Black")
                .SetStats(10, 4, 0)
                .SetSprites("dusclops.png", "dusclopsBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("absol", "Absol")
                .SetStats(5, 5, 2)
                .SetSprites("absol.png", "absolBG.png")
                .WithFlavour("Once mistaken to be the bringer of Wildfrost")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("spheal", "Spheal", idleAnim: "PingAnimationProfile")
                .SetStats(4, 1, 3)
                .SetSprites("spheal.png", "sphealBG.png")
                .AddPool("BasicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("latias", "Latias")
                .SetStats(8, 0, 3)
                .SetSprites("latias.png", "latiasBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("latios", "Latios")
                .SetStats(8, 0, 3)
                .SetSprites("latios.png", "latiosBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("piplup", "Piplup", bloodProfile: "Blood Profile Snow")
                .SetStats(6, 2, 3)
                .SetSprites("piplup.png", "piplupBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("prinplup", "Prinplup", bloodProfile: "Blood Profile Snow")
                .SetStats(7, 2, 3)
                .SetSprites("prinplup.png", "prinplupBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("empoleon", "Empoleon", bloodProfile: "Blood Profile Snow")
                .SetStats(8, 2, 3)
                .SetSprites("empoleon.png", "empoleonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("bastiodon", "Bastiodon", idleAnim: "SquishAnimationProfile")
                .SetStats(10, 4, 6)
                .SetSprites("bastiodon.png", "bastiodonBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("ambipom", "Ambipom")
                .SetStats(6, 2, 3)
                .SetSprites("ambipom.png", "ambipomBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("honchkrow", "Honchkrow", idleAnim: "SquishAnimationProfile")
                .SetStats(7, 4, 4)
                .SetSprites("honchkrow.png", "honchkrowBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("chingling", "Chingling", idleAnim: "HangAnimationProfile")
                .SetStats(6, 3, 0)
                .SetSprites("chingling.png", "chinglingBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("hippowdon", "Hippowdon", idleAnim: "SquishAnimationProfile")
                .SetStats(12, 3, 5)
                .SetSprites("hippowdon.png", "hippowdonBG.png")
                .AddPool("ClunkUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("munchlax", "Munchlax")
                .SetStats(7, 3, 5)
                .SetSprites("munchlax.png", "munchlaxBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("croagunk", "Croagunk", bloodProfile: "Blood Profile Fungus")
                .SetStats(6, 2, 5)
                .SetSprites("croagunk.png", "croagunkBG.png")
                .AddPool("BasicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("toxicroak", "Toxicroak", bloodProfile: "Blood Profile Fungus")
                .SetStats(6, 3, 4)
                .SetSprites("toxicroak.png", "toxicroakBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("lumineon", "Lumineon")
                .SetStats(8, null, 3)
                .SetSprites("lumineon.png", "lumineonBG.png")
                .STraits(("Salvage", 1))
                .AddPool()
            );

        /*assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("snover", "Snover")
                .SetStats(6, 4, 4)
                .SetSprites("snover.png", "snoverBG.png")
            );*/

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("abomasnow", "Abomasnow")
                .SetStats(10, 4, 4)
                .SetSprites("abomasnow.png", "abomasnowBG.png")
                .AddPool("SnowUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("lickilicky", "Lickilicky", idleAnim: "SquishAnimationProfile", bloodProfile: "Blood Profile Berry")
                .SetStats(8, 3, 3)
                .SetSprites("lickilicky.png", "lickilickyBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("leafeon", "Leafeon", bloodProfile: "Blood Profile Fungus")
                .SetStats(4, 1, 3)
                .SetSprites("leafeon.png", "leafeonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("glaceon", "Glaceon", bloodProfile: "Blood Profile Snow")
                .SetStats(4, 3, 3)
                .SetSprites("glaceon.png", "glaceonBG.png")
            );

        /*assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("porygonz", "Porygon-Z")
                .SetStats(5, 5, 5)
                .SetSprites("porygonz.png", "porygonzBG.png")
            );*/

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("gallade", "Gallade")
                .SetStats(5, 5, 5)
                .SetSprites("gallade.png", "galladeBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("froslass", "Froslass", idleAnim: "FloatAnimationProfile", bloodProfile: "Blood Profile Pink Wisp")
                .SetStats(4, 1, 4)
                .SetSprites("froslass.png", "froslassBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("rotom", "Rotom", idleAnim: "Heartbeat2AnimationProfile", bloodProfile: "Blood Profile Blue (x2)")
                .SetStats(8, 3, 4)
                .SetSprites("rotom.png", "rotomBG.png")
                .IsPet((ChallengeData)null, true)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("rotomheat", "Rotom Heat", bloodProfile: "Blood Profile Black")
                .SetStats(5, 5, 4)
                .SetSprites("rotomheat.png", "rotomBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("rotomwash", "Rotom Wash", bloodProfile: "Blood Profile Black")
                .SetStats(10, 5, 4)
                .SetSprites("rotomwash.png", "rotomBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("rotomfrost", "Rotom Frost", bloodProfile: "Blood Profile Black")
                .SetStats(10, 2, 4)
                .SetSprites("rotomfrost.png", "rotomBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("rotomfan", "Rotom Fan", bloodProfile: "Blood Profile Black")
                .SetStats(6, 4, 4)
                .SetSprites("rotomfan.png", "rotomBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("rotommow", "Rotom Mow", idleAnim: "ShakeAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(7, 3, 0)
                .SetSprites("rotommow.png", "rotomBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("cresselia", "Cresselia")
                .SetStats(8, 2, 4)
                .SetSprites("cresselia.png", "cresseliaBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("darkrai", "Darkrai")
                .SetStats(6, 3, 4)
                .SetSprites("darkrai.png", "darkraiBG.png")
                .WithCardType("Leader")
                .WithText("<keyword=legendary>")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("musharna", "Musharna", idleAnim: "FloatAnimationProfile")
                .SetStats(7, 3, 0)
                .SetSprites("musharna.png", "musharnaBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("crustle", "Crustle", idleAnim: "GiantAnimationProfile", bloodProfile: "Blood Profile Husk")
                .SetStats(8, 3, 4)
                .SetSprites("crustle.png", "crustleBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("trubbish", "Trubbish", idleAnim: "SquishAnimationProfile", bloodProfile: "Blood Profile Husk")
                .SetStats(6, 3, 4)
                .SetSprites("trubbish.png", "trubbishBG.png")
                .AddPool("ClunkUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("garbodor", "Garbodor", idleAnim: "GiantAnimationProfile", bloodProfile: "Blood Profile Husk")
                .SetStats(6, 3, 4)
                .SetSprites("garbodor.png", "garbodorBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("litwick", "Litwick", idleAnim: "SquishAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(3, 0, 2)
                .SetSprites("litwick.png", "litwickBG.png")
                .AddPool("MagicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("lampent", "Lampent", idleAnim: "HangAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(10, 0, 4)
                .SetSprites("lampent.png", "lampentBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("chandelure", "Chandelure", idleAnim: "HangAnimationProfile", bloodProfile: "Blood Profile Black")
                .SetStats(10, 0, 4)
                .SetSprites("chandelure.png", "chandelureBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("volcarona", "Volcarona", idleAnim: "FlyAnimationProfile")
                .SetStats(6, 4, 4)
                .SetSprites("volcarona.png", "volcaronaBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("espurr", "Espurr", idleAnim: "PulseAnimationProfile")
                .SetStats(2, null, 0)
                .SetSprites("espurr.png", "espurrBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("tyrantrum", "Tyrantrum", idleAnim: "GiantAnimationProfile")
                .SetStats(7, 4, 4)
                .SetSprites("tyrantrum.png", "tyrantrumBG.png")
                .WithFlavour("Seems to have been frozen long before the storm")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("sylveon", "Sylveon", bloodProfile: "Blood Profile Berry")
                .SetStats(4, 3, 3)
                .SetSprites("sylveon.png", "sylveonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("goomy", "Goomy", idleAnim: "SquishAnimationProfile", bloodProfile: "Blood Profile Blue (x2)")
                .SetStats(13, 1, 3)
                .SetSprites("goomy.png", "goomyBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("klefki", "Klefki", idleAnim: "ShakeAnimationProfile", bloodProfile: "Blood Profile Husk")
                .SetStats(6, 2, 2)
                .SetSprites("klefki.png", "klefkiBG.png")
                .WithFlavour("I can hold all of your charms for safe keeping ;)")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("salazzle", "Salazzle")
                .SetStats(7, 1, 3)
                .SetSprites("salazzle.png", "salazzleBG.png")
                .AddPool("BasicUnitPool")
                .AddPool("MagicUnitPool")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("polteageist", "Polteageist", idleAnim: "FloatAnimationProfile", bloodProfile: "Blood Profile Husk")
                .SetStats(7, null, 4)
                .SetSprites("polteageist.png", "polteageistBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("kingambit", "Kingambit", idleAnim: "GiantAnimationProfile")
                .SetStats(10, 5, 5)
                .SetSprites("kingambit.png", "kingambitBG.png")
                .AddPool()
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateItem("shedinjamask", "Shedinja Mask", idleAnim: "FloatAnimationProfile")
                .SetSprites("shedinja_mask.png", "shedinja_maskBG.png")
                .CanPlayOnBoard(true)
                .CanPlayOnEnemy(false)
                .FreeModify(delegate (CardData c)
                {
                    c.playOnSlot = true;
                })
                .STraits(("Consume", 1))
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateItem("microwave", "Microwave")
                .SetSprites("microwave.png", "rotomBG.png")
                .WithFlavour("Appears to be a safe without a lock. What use is that?")
                .CanPlayOnFriendly(false)
                .CanPlayOnEnemy(false)
                .NeedsTarget(false)
                .WithPlayType(Card.PlayType.None)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateItem("washingmachine", "Washing Machine")
                .SetSprites("washingmachine.png", "rotomBG.png")
                .WithFlavour("A device that spins and makes loud noises. What use is that?")
                .CanPlayOnFriendly(false)
                .CanPlayOnEnemy(false)
                .NeedsTarget(false)
                .CanPlayOnBoard(false)
                .WithPlayType(Card.PlayType.None)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateItem("fridge", "Fridge")
                .SetSprites("fridge.png", "rotomBG.png")
                .WithFlavour("This strange device seems to... keep things cold? What use is that?")
                .CanPlayOnFriendly(false)
                .CanPlayOnEnemy(false)
                .NeedsTarget(false)
                .CanPlayOnBoard(false)
                .WithPlayType(Card.PlayType.None)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateItem("fan", "Fan")
                .SetSprites("fan.png", "rotomBG.png")
                .WithFlavour("A strange saw sealed by an even stranger cage. What use is that?")
                .CanPlayOnFriendly(false)
                .CanPlayOnEnemy(false)
                .NeedsTarget(false)
                .CanPlayOnBoard(false)
                .WithPlayType(Card.PlayType.None)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateItem("lawnmower", "Lawnmower")
                .SetSprites("lawnmower.png", "rotomBG.png")
                .WithFlavour("Seems to be some sort of vehicle, but lacks seating. What use is that?")
                .CanPlayOnFriendly(false)
                .CanPlayOnEnemy(false)
                .NeedsTarget(false)
                .CanPlayOnBoard(false)
                .WithPlayType(Card.PlayType.None)
            );


        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_hypno", "Hypno")
                .SetStats(20, 3, 4)
                .SetSprites("hypno.png", "hypnoBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_vaporeon", "Vaporeon", bloodProfile: "Blood Profile Blue (x2)")
                .SetStats(8, 3, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("vaporeon.png", "vaporeonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_jolteon", "Jolteon")
                .SetStats(8, 1, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("jolteon.png", "jolteonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_flareon", "Flareon")
                .SetStats(8, 2, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("flareon.png", "flareonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_espeon", "Espeon")
                .SetStats(10, 0, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("espeon.png", "espeonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_umbreon", "Umbreon")
                .SetStats(10, 0, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("umbreon.png", "umbreonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_raikou", "Raikou")
                .SetStats(30, 3, 4)
                .SetSprites("raikou.png", "raikouBG.png")
                .WithCardType("Miniboss")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_entei", "Entei")
                .SetStats(25, 0, 4)
                .SetSprites("entei.png", "enteiBG.png")
                .WithCardType("Miniboss")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_suicune", "Suicune")
                .SetStats(35, 2, 4)
                .SetSprites("suicune.png", "suicuneBG.png")
                .WithCardType("Miniboss")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_hooh", "Ho-Oh")
                .SetStats(100, 5, 5)
                .SetSprites("hooh.png", "hoohBG.png")
                .WithCardType("Boss")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_beautifly", "Beautifly")
                .SetStats(6, 1, 2)
                .SetSprites("beautifly.png", "beautiflyBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_dustox", "Dustox")
                .SetStats(6, 2, 2)
                .SetSprites("dustox.png", "dustoxBG.png")
                .WithCardType("Enemy")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_plusle", "Plusle")
                .SetStats(14, 3, 5)
                .SetSprites("plusle.png", "plusleBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_minun", "Minun")
                .SetStats(14, 3, 5)
                .SetSprites("minun.png", "minunBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_volbeat", "Volbeat")
                .SetStats(10, 1, 3)
                .SetSprites("volbeat.png", "volbeatBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_illumise", "Illumise")
                .SetStats(10, 1, 3)
                .SetSprites("illumise.png", "illumiseBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_lunatone", "Lunatone")
                .SetStats(8, null, 5)
                .SetSprites("lunatone.png", "lunatoneBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_solrock", "Solrock")
                .SetStats(8, null, 5)
                .SetSprites("solrock.png", "solrockBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_huntail", "Huntail")
                .SetStats(10, 2, 0)
                .SetSprites("huntail.png", "huntailBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_gorebyss", "Gorebyss")
                .SetStats(14, 0, 5)
                .SetSprites("gorebyss.png", "gorebyssBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_latias", "Latias")
                .SetStats(30, 2, 5)
                .SetSprites("latias.png", "latiasBG.png")
                .WithCardType("Miniboss")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_latios", "Latios")
                .SetStats(30, 5, 4)
                .SetSprites("latios.png", "latiosBG.png")
                .WithCardType("Miniboss")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_mismagius", "Mismagius")
                .SetStats(8, 0, 2)
                .SetSprites("mismagius.png", "mismagiusBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_spiritomb", "Spiritomb")
                .SetStats(12, 0, 0)
                .SetSprites("spiritomb.png", "spiritombBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_magmortar", "Magmortar")
                .SetStats(10, 7, 5)
                .SetSprites("magmortar.png", "magmortarBG.png")
                .WithCardType("Enemy")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_leafeon", "Leafeon", bloodProfile: "Blood Profile Fungus")
                .SetStats(10, 1, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("leafeon.png", "leafeonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_glaceon", "Glaceon", bloodProfile: "Blood Profile Snow")
                .SetStats(10, 3, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("glaceon.png", "glaceonBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("quest_cresselia", "Cresselia")
                .WithCardType("Summoned")
                .SetStats(4, null, 6)
                .SetSprites("cresselia.png", "cresseliaBG.png")
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_darkrai", "Darkrai")
                .SetStats(50, 2, 4)
                .SetSprites("darkrai.png", "darkraiBG.png")
                .WithCardType("Miniboss")
                .WithValue(50)
            );

        assets.Add(
            new CardDataBuilder(this)
                .CreateUnit("enemy_sylveon", "Sylveon", bloodProfile: "Blood Profile Berry")
                .SetStats(10, 2, 3)
                .WithCardType("Enemy")
                .WithValue(50)
                .SetSprites("sylveon.png", "sylveonBG.png")
            );

        //
    }

    private void AddGreetings()
    {
        foreach (CardDataBuilder builder in assets)
        {
            builder.FreeModify((data) =>
            {
                data.greetMessages = new string[] { "Oh! A wild <name> appeared!", "Hey! <name> wants to join your team!", "\"<name>?\" (This Pokemon is waiting for a response.)" };
            });
        }
    }

    private void CreateModAssetsCharms()
    {
        Debug.Log("[Pokefrost] Loading Charms");

        CardUpgradeData fish = Get<CardUpgradeData>("CardUpgradeAimless");
        CardUpgradeData pom = Get<CardUpgradeData>("CardUpgradeBarrage");
        CardUpgradeData gnome = Get<CardUpgradeData>("CardUpgradeWildcard");
        TargetConstraintHasTrait nopluck = new TargetConstraintHasTrait();
        nopluck.name = "Does Not Have Pluck";
        nopluck.trait = Get<TraitData>("Pluck");
        nopluck.not = true;
        TargetConstraintHasTrait noaimless = new TargetConstraintHasTrait();
        noaimless.name = "Does Not Have Aimless";
        noaimless.trait = Get<TraitData>("Aimless");
        noaimless.not = true;
        TargetConstraint[] crow = new TargetConstraint[] { };
        foreach (TargetConstraint tc in fish.targetConstraints) { crow = crow.Append(tc).ToArray(); };
        crow = crow.Append(noaimless).ToArray();
        fish.targetConstraints = fish.targetConstraints.Append(nopluck).ToArray();
        pom.targetConstraints = pom.targetConstraints.Append(nopluck).ToArray();
        gnome.targetConstraints = gnome.targetConstraints.Append(nopluck).ToArray();

        TargetConstraintStatusMoreThan thickclubconstraint = ScriptableObject.CreateInstance<TargetConstraintStatusMoreThan>();
        thickclubconstraint.not = true;
        thickclubconstraint.status = Get<StatusEffectData>("On Card Played Buff Marowak");
        thickclubconstraint.amount = 0;

        //Add our cards here
        assets.Add(
            new CardUpgradeDataBuilder(this)
                .CreateCharm("CardUpgradeMagnemite")
                .WithTier(1)
                .WithImage("magnemiteCharm.png")
                .WithType(CardUpgradeData.Type.Charm)
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeShroom").targetConstraints)
                .SetBecomesTarget(true)
                .WithTitle("Magnemite Charm")
                .WithText("Apply <1><keyword=shroom>/<keyword=overload>/<keyword=weakness> randomly")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .CreateCharm("CardUpgradePluck")
                .WithTier(0)
                .WithImage("murkrowCharm.png")
                .WithType(CardUpgradeData.Type.Charm)
                .SetConstraints(crow)
                .ChangeDamage(1)
                .WithTitle("Murkrow Charm")
                .WithText("Gain <keyword=pluck>\n<+1><keyword=attack>\nCA-CAW")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .CreateCharm("CardUpgradeSketch")
                .WithTier(3)
                .WithImage("smeargleCharm.png")
                .WithType(CardUpgradeData.Type.Charm)
                .ChangeDamage(-2)
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeBlock").targetConstraints[0], Get<CardUpgradeData>("CardUpgradePig").targetConstraints[1], Get<CardUpgradeData>("CardUpgradeBarrage").targetConstraints[2])
                .WithTitle("Smeargle Charm")
                .WithText("Gain <keyword=sketch> <1>, <keyword=pigheaded> and reduce <keyword=attack> by <2>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .Create("CardUpgradeConduit")
                .WithType(CardUpgradeData.Type.Charm)
                .WithTier(2)
                .WithImage("raikouCharm.png")
                .SetBecomesTarget(true)
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2])
                .WithTitle("Raikou Charm")
                .WithText("Apply <1><keyword=jolted> and gain <keyword=conduit><color=#F99C61>: Trigger</color>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .Create("CardUpgradeJuice")
                .WithType(CardUpgradeData.Type.Charm)
                .WithTier(2)
                .WithImage("suicuneCharm.png")
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1], Get<CardUpgradeData>("CardUpgradeCake").targetConstraints[1])
                .WithTitle("Suicune Charm")
                .WithText("Start with <4><keyword=spicune>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .Create("CardUpgradeResist")
                .WithType(CardUpgradeData.Type.Charm)
                .WithTier(2)
                .WithImage("latiasCharm.png")
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2])
                .WithTitle("Latias Charm")
                .WithText("Gain <keyword=resist> <1>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .CreateCharm("CardUpgradeTaunt")
                .WithTier(1)
                .WithImage("shieldonCharm.png")
                .WithType(CardUpgradeData.Type.Charm)
                .ChangeHP(3)
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeHeart").targetConstraints)
                .WithTitle("Shieldon Charm")
                .WithText("Gain <keyword=taunt>\n<+3><keyword=health>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .Create("CardUpgradeCurse")
                .WithType(CardUpgradeData.Type.Charm)
                .WithTier(2)
                .WithImage("darkraiCharm.png")
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeFrenzyConsume").targetConstraints)
                .WithTitle("Darkrai Charm")
                .WithText("Gain <keyword=curseoffrenzy>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .CreateCharm("CardUpgradeTyrunt")
                .WithTier(1)
                .WithImage("tyruntCharm.png")
                .WithType(CardUpgradeData.Type.Charm)
                .SetAttackEffects(new CardData.StatusEffectStacks(Get<StatusEffectData>("Apply Wild Trait"), 1))
                .SetBecomesTarget(true)
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1], Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2])
                .WithTitle("Tyrunt Charm")
                .WithText("Gain <keyword=wild>\nApply <keyword=wild>\nBE <WILD>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .CreateCharm("CardUpgradeRevive")
                .WithTier(1)
                .WithImage("reviveCharm.png")
                .WithType(CardUpgradeData.Type.Charm)
                .SetConstraints(Get<CardUpgradeData>("CardUpgradeHeart").targetConstraints[0])
                .WithTitle("Revive Charm")
                .WithText("Gain <keyword=revive>")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .Create("CardUpgradeThickClub")
                .WithType(CardUpgradeData.Type.Charm)
                .WithTier(-1)
                .WithImage("thickclubCharm.png")
                .SetConstraints(thickclubconstraint)
                .WithTitle("Thick Club")
                .WithText("Gain 'increase <Marowak's> <keyword=health> or <keyword=attack> by <1>'\n\nRandomly each trigger")
        );

        assets.Add(
            new CardUpgradeDataBuilder(this)
                .Create("CrownSlowking")
                .WithType(CardUpgradeData.Type.Crown)
                .WithImage("slowking_crown.png")
                .ChangeCounter(2)
                .WithTitle("Shellder Crown")
                .WithText("Cards with Crowns are always played at the start of battle\n\nIncrease <keyword=counter> by <2>")
                //.SetConstraints(Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[1], Get<CardUpgradeData>("CardUpgradeSpark").targetConstraints[2])
                .SetCanBeRemoved(true)
        );
    }
}

public static class DoNothing
{
    public static CardDataBuilder STraits(this CardDataBuilder obj, params object[] objects) => obj;
    public static CardData.StatusEffectStacks SStack(params object[] objects) => new();
}
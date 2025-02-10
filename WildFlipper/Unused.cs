using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFlipper
{
    internal class Unused
    {

        /*async public override void Load()
        {
            base.Load();
            
            string[] adds = File.ReadAllLines(Path.Combine(Application.persistentDataPath, "addressables.txt"));
            string[] scenes = """
                    Battle
                    3
                    BattleWin
                    4
                    Bootstrap
                    0
                    BossReward
                    5
                    Camera
                    7
                    Campaign
                    8
                    CampaignEnd
                    9
                    CardCombine
                    6
                    CardFramesUnlocked
                    29
                    Cards
                    10
                    CharacterSelect
                    11
                    Console
                    12
                    ContinueRun
                    13
                    Credits
                    27
                    CreditsEnd
                    28
                    DemoEnd
                    14
                    Event
                    15
                    Global
                    1
                    Input
                    16
                    JournalNameHistory
                    2
                    MainMenu
                    17
                    MapNew
                    18
                    Mods
                    30
                    NewFrostGuardian
                    26
                    PauseScreen
                    19
                    PetSelect
                    20
                    Saving
                    21
                    Systems
                    22
                    Town
                    23
                    TownUnlocks
                    24
                    UI
                    25
                    """.Split(["\r\n"], StringSplitOptions.RemoveEmptyEntries);
            string[] ignore = """
                    DebugUICanvas
                    DebugUIPersistentCanvas
                    ES3/ES3Defaults
                    ES3/ES3GlobalReferences
                    FMODStudioSettings
                    Fonts & Materials/LiberationSans SDF
                    Fonts & Materials/LiberationSans SDF - Drop Shadow
                    Fonts & Materials/LiberationSans SDF - Fallback
                    Fonts & Materials/LiberationSans SDF - Outline
                    GameAnalytics/Settings
                    iso4217
                    LineBreaking Following Characters
                    LineBreaking Leading Characters
                    NexInitializer
                    Ranking2Board
                    RankingBoard
                    Shaders/TMP_Bitmap
                    Shaders/TMP_Bitmap-Custom-Atlas
                    Shaders/TMP_Bitmap-Mobile
                    Shaders/TMP_SDF
                    Shaders/TMP_SDF Overlay
                    Shaders/TMP_SDF-Mobile
                    Shaders/TMP_SDF-Mobile Masking
                    Shaders/TMP_SDF-Mobile Overlay
                    Shaders/TMP_SDF-Surface
                    Shaders/TMP_SDF-Surface-Mobile
                    Shaders/TMP_Sprite
                    Sprite Assets/EmojiOne
                    Style Sheets/Default Style Sheet
                    TMP Settings
                    """.Split(["\r\n"], StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in adds)
            {
                if (scenes.Contains(s)) continue;
                if (ignore.Contains(s)) continue;

                //Debug.LogWarning(s);
                *//*handle = Addressables.LoadAssetAsync<object>(s);
                if (!handle.IsValid()) continue;

                handle.WaitForCompletion();
                var res = handle.Result;*//*
                var res = GetAsset<object>(s);

                var type = res.GetType();
                Type[] ts = [typeof(BossRewardData), typeof(ChallengeListener),
                    typeof(BuildingPlotType), typeof(BuildingType)
                ];
                if (res is DataFile && ts.All(t => !t.IsAssignableFrom(type)))
                    continue;

                Debug.Log($"{s}\t{res.GetType()}\t{(res is UnityEngine.Object obj ? obj.name : res)}");
            }

            //Debug.LogWarning(Addressables.LoadAssetAsync<TMP_SpriteAsset>("Sprite Assets/EmojiOne").WaitForCompletion());



            IEnumerator logger()
            {
                Debug.LogWarning("OWOWOWOAOEOAWODAOWOAW");
                do Debug.Log(handle.Status);
                while (!handle.IsValid() || !handle.IsDone);
                yield return null;
            }

            IEnumerator loader()
            {
                string[] adds = File.ReadAllLines(Path.Combine(Application.persistentDataPath, "addressables.txt"));
                foreach (string s in adds)
                {
                    string[] ignore = """
                    DebugUICanvas
                    DebugUIPersistentCanvas
                    ES3/ES3Defaults
                    ES3/ES3GlobalReferences
                    FMODStudioSettings
                    Fonts & Materials/LiberationSans SDF
                    """.Split('\n');
                    if (ignore.Contains(s)) continue;

                    Debug.LogWarning(s);
                    handle = Addressables.LoadAssetAsync<object>(s);
                    if (!handle.IsValid()) continue;

                    CoroutineManager.Start(logger());
                    yield return new WaitUntil(() => handle.IsDone);
                }
                yield return null;
            }

            //CoroutineManager.Start(loader());




            behaviour = new GameObject(Title, typeof(Image), typeof(WorldSpaceCanvasFitScreen));
            GameObject.DontDestroyOnLoad(behaviour);
            behaviour.GetOrAdd<Image>().color = Color.white.WithAlpha(0.3f);
            behaviour.GetOrAdd<WorldSpaceCanvasFitScreen>().padding = 0.6f * Vector2.one;

            var e = behaviour.AddComponent<WildFlipperModBehaviour>();
        }*/
    }
}

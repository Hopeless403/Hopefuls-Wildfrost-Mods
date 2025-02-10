using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WildfrostHopeMod.CommandsConsole
{
    public class PatchCampaignDataWithEvents
    {
        public static Task SaveCampaignDatas()
        {
            Debug.LogWarning("~CAMPAIGN GENERATED~");
            string preset = Campaign.instance.preset.text;
            SaveSystem.SaveCampaignData(Campaign.Data.GameMode, $"hope.preset", preset);

            var rewards = References.Player.GetComponent<CharacterRewards>().poolLookup;
            var _rewards = new Dictionary<string, SaveCollection<string>>();
            foreach (string category in rewards.Keys)
            {
                _rewards[category] = rewards[category].list.ToSaveCollectionOfNames();
            }

            SaveSystem.SaveCampaignData(Campaign.Data.GameMode, "hope.rewards", _rewards);
            return Task.CompletedTask;
        }
        public static void LoadCampaignDatas()
        {
            if (!Campaign.instance || Campaign.Data == null)
                return;
            Debug.LogWarning("~CAMPAIGN LOADED~");
            string preset = SaveSystem.LoadCampaignData<string>(Campaign.Data.GameMode, "hope.preset", null);
            Campaign.instance.preset ??= new TextAsset(preset);
            Debug.LogWarning("[AConsole] Reusing campaign preset from custom data:\n" + preset);

            var _rewards = SaveSystem.LoadCampaignData<Dictionary<string, SaveCollection<string>>>(Campaign.Data.GameMode, "hope.rewards", []);
            var rewards = new Dictionary<string, CharacterRewards.Pool>();
            foreach (string category in _rewards.Keys)
            {
                rewards[category] = new CharacterRewards.Pool() { list = [] };
                foreach (string name in _rewards[category].collection)
                {
                    Type type = category switch
                    {
                        "Items" or "Units" => typeof(CardData),
                        "Charms" => typeof(CardUpgradeData),
                        "Modifiers" => typeof(GameModifierData),
                        _ => null,
                    };
                    if (type == null)
                    {
                        Debug.LogError($"[AConsole] Unrecognised CharacterReward category [{category}]. Couldn't assign decide which AddressableLoader group it belonged to");
                        continue;
                    }
                    DataFile data = AddressableLoader.Get<DataFile>(type.Name, name);
                    rewards[category].Add(data);
                }
            }

            var poolLookup = References.Player.GetComponent<CharacterRewards>()?.poolLookup;
            if (poolLookup == null)
                return;

            foreach (var key in rewards.Keys)
                poolLookup[key] = rewards[key];
            Debug.LogWarning("[AConsole] Reusing character rewards from custom data:");
            foreach (var pool in poolLookup)
            {
                Debug.LogWarning($"[AConsole] {pool.Key}");
                Debug.Log(string.Join(", ", pool.Value.list?.ToArrayOfNames().DefaultIfEmpty("") ?? [""] ));
            }
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Zutatensuppe.D2Reader;
using Zutatensuppe.D2Reader.Models;
using Zutatensuppe.DiabloInterface.Lib;

namespace DiabloInterface.Plugin.HttpClient
{
    // Class to hold quest completion details
    public class QuestCompletionDetails
    {
        public QuestId Id { get; set; }
        public string Name { get; set; }
        public ushort CompletionBits { get; set; }
        public bool IsCompleted { get; set; }
        public List<int> CompletedBits { get; set; }
    }
    class RequestBody
    {
        private static readonly List<string> AutocompareProps = new List<string> {
            "Area",
            "InventoryTab",
            "Difficulty",
            "PlayersX",
            "Seed",
            "SeedIsArg",
            "Name",
            "CharClass",
            "IsHardcore",
            "IsExpansion",
            "IsDead",
            "Deaths",
            "Level",
            "Experience",
            "Strength",
            "Dexterity",
            "Vitality",
            "Energy",
            "Life",
            "LifeMax",
            "Mana",
            "ManaMax",
            "FireResist",
            "ColdResist",
            "LightningResist",
            "PoisonResist",
            "Gold",
            "GoldStash",
            "FasterCastRate",
            "FasterHitRecovery",
            "FasterRunWalk",
            "IncreasedAttackSpeed",
            "MagicFind",
            "DamageMax",
            "Defense",
            "AttackRating",
        };

        public string Event { get; private set; }

        public string Headers { get; set; }
        public int? Area { get; set; }
        public byte? InventoryTab { get; set; }
        public GameDifficulty? Difficulty { get; set; }
        public int? PlayersX { get; set; }
        public uint? Seed { get; set; }
        public bool? SeedIsArg { get; set; }
        public uint? GameCount { get; set; }
        public uint? CharCount { get; set; }
        public bool? NewCharacter { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        public CharacterClass? CharClass { get; set; }
        public bool? IsHardcore { get; set; }
        public bool? IsExpansion { get; set; }
        public bool? IsDead { get; set; }
        public short? Deaths { get; set; }
        public int? Level { get; set; }
        public int? Experience { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Vitality { get; set; }
        public int? Energy { get; set; }
        public int? FireResist { get; set; }
        public int? ColdResist { get; set; }
        public int? LightningResist { get; set; }
        public int? PoisonResist { get; set; }
        public int? Gold { get; set; }
        public int? GoldStash { get; set; }
        public int? Life { get; set; }
        public int? LifeMax { get; set; }
        public int? Mana { get; set; }
        public int? ManaMax { get; set; }
        public int? FasterCastRate { get; set; }
        public int? FasterHitRecovery { get; set; }
        public int? FasterRunWalk { get; set; }
        public int? IncreasedAttackSpeed { get; set; }
        public int? DamageMax { get; set; }
        public int? Defense { get; set; }
        public int? AttackRating { get; set; }
        public int? VelocityPercent { get; set; }
        public int? MagicFind { get; set; }
        public List<ItemInfo> Items { get; set; }
        public List<ItemInfo> AddedItems { get; set; }
        public List<ItemInfo> RemovedItems { get; set; }
        public List<SkillInfo> Skills { get; set; }
        public Dictionary<GameDifficulty, List<QuestId>> Quests { get; set; }
        public Dictionary<GameDifficulty, List<QuestId>> CompletedQuests { get; set; }

        public List<QuestCompletionDetails> AllQuestsDetails { get; set; }


        public HirelingDiff Hireling { get; set; }

        public List<Monster> KilledMonsters { get; set; }

        [JsonConverter(typeof(ProcessInfoConverter))]
        public ProcessInfo D2ProcessInfo { get; set; }

        [JsonConverter(typeof(DIApplicationInfoConverter))]
        public IApplicationInfo DIApplicationInfo { get; set; }


        private static bool IsBitSet(ushort questBits, int bit)
        {
            return (questBits & (1 << bit)) != 0;
        }


        public static RequestBody FromDataReadEventArgs(DataReadEventArgs e, IDiabloInterface di)
        {
            // Get only the quests for the current difficulty.
            var questsForCurrentDifficulty = e.Quests.ByDifficulty(e.Game.Difficulty);

            // Create a list of quest details for current difficulty.
            var questDetailsForCurrentDifficulty = questsForCurrentDifficulty
                .Select(quest => new
                {
                    Name = quest.Name,
                    CompletedBits = Enumerable.Range(0, 16)
                        .Where(bitIndex => IsBitSet(quest.CompletionBits, bitIndex))
                        .ToList()
                })
                .Where(q => q.CompletedBits.Count > 0) // Filter out quests with no completed bits.
                .ToList();

            // Transform into QuestCompletionDetails for the JSON output.
            var allQuestsDetails = questDetailsForCurrentDifficulty.Select(q => new QuestCompletionDetails
            {
                Name = q.Name,
                CompletedBits = q.CompletedBits
            }).ToList();



            return new RequestBody()
            {
                Event = "DataRead",
                Area = e.Game.Area,
                InventoryTab = e.Game.InventoryTab,
                Difficulty = e.Game.Difficulty,
                PlayersX = e.Game.PlayersX,
                Seed = e.Game.Seed,
                SeedIsArg = e.Game.SeedIsArg,
                GameCount = e.Game.GameCount,
                CharCount = e.Game.CharCount,
                Name = e.Character.Name,
                Guid = e.Character.Guid,
                CharClass = e.Character.CharClass,
                IsHardcore = e.Character.IsHardcore,
                IsExpansion = e.Character.IsExpansion,
                IsDead = e.Character.IsDead,
                Deaths = e.Character.Deaths,
                Level = e.Character.Level,
                Experience = e.Character.Experience,
                Strength = e.Character.Strength,
                Dexterity = e.Character.Dexterity,
                Vitality = e.Character.Vitality,
                Energy = e.Character.Energy,
                Life = e.Character.Life,
                LifeMax = e.Character.LifeMax,
                Mana = e.Character.Mana,
                ManaMax = e.Character.ManaMax,
                FireResist = e.Character.FireResist,
                ColdResist = e.Character.ColdResist,
                LightningResist = e.Character.LightningResist,
                PoisonResist = e.Character.PoisonResist,
                Gold = e.Character.Gold,
                GoldStash = e.Character.GoldStash,
                FasterCastRate = e.Character.FasterCastRate,
                FasterHitRecovery = e.Character.FasterHitRecovery,
                FasterRunWalk = e.Character.FasterRunWalk,
                IncreasedAttackSpeed = e.Character.IncreasedAttackSpeed,
                VelocityPercent = e.Character.VelocityPercent,
                AttackRating = e.Character.AttackRating,
                DamageMax = e.Character.DamageMax,
                MagicFind = e.Character.MagicFind,
                Defense = e.Character.Defense,
                Items = e.Character.Items,
                Skills = e.Character.Skills,
                Quests = e.Quests.CompletedQuestIds,
                Hireling = new HirelingDiff
                {
                    Name = e.Game.Hireling?.Name,
                    Class = e.Game.Hireling?.Class,
                    Skills = e.Game.Hireling?.Skills,
                    Level = e.Game.Hireling?.Level,
                    Experience = e.Game.Hireling?.Experience,
                    Strength = e.Game.Hireling?.Strength,
                    Dexterity = e.Game.Hireling?.Dexterity,
                    FireResist = e.Game.Hireling?.FireResist,
                    ColdResist = e.Game.Hireling?.ColdResist,
                    LightningResist = e.Game.Hireling?.LightningResist,
                    PoisonResist = e.Game.Hireling?.PoisonResist,
                    Items = e.Game.Hireling?.Items
               
                },
                KilledMonsters = e.KilledMonsters,
                D2ProcessInfo = e.ProcessInfo,
                DIApplicationInfo = di.appInfo,
                AllQuestsDetails = allQuestsDetails,

            };
        }

        public static RequestBody FromProcessFoundEventArgs(ProcessFoundEventArgs e, IDiabloInterface di)
        {
            return new RequestBody()
            {
                Event = "ProcessFound",
                D2ProcessInfo = e.ProcessInfo,
                DIApplicationInfo = di.appInfo,
            };
        }

        public static RequestBody GetDiff(
            RequestBody curr,
            RequestBody prev
)
        {
            var diff = new RequestBody();

            // TODO: while this check is correct, D2DataReader should probably
            //       provide the information about 'new char or not' directly
            //       in a property of the DataReadEventArgs
            if (curr.CharCount > 0 && !curr.CharCount.Equals(prev.CharCount))
            {
                diff.NewCharacter = true;
                prev = new RequestBody();
            }

            if (!curr.GameCount.Equals(prev.GameCount))
            {
                prev = new RequestBody();
            }

            var hasDiff = false;
            foreach (string propertyName in AutocompareProps)
            {
                var property = typeof(RequestBody).GetProperty(propertyName);
                var prevValue = property.GetValue(prev);
                var newValue = property.GetValue(curr);
                if (!DiffUtil.ObjectsEqual(prevValue, newValue))
                {
                    hasDiff = true;
                    property.SetValue(diff, newValue);
                }
            }

            // Compare AllQuestsDetails using the custom comparer.
            if (curr.AllQuestsDetails != null &&
                (prev.AllQuestsDetails == null ||
                 !curr.AllQuestsDetails.SequenceEqual(prev.AllQuestsDetails, new QuestCompletionDetailsComparer())))
            {
                diff.AllQuestsDetails = curr.AllQuestsDetails;
                hasDiff = true;
            }

            var itemsDiff = DiffUtil.ItemsDiff(curr.Items, prev.Items);
            diff.AddedItems = itemsDiff.Item1;
            diff.RemovedItems = itemsDiff.Item2;

            if (!DiffUtil.ListsEqual(curr.Skills, prev.Skills))
                diff.Skills = curr.Skills;

            diff.CompletedQuests = DiffUtil.CompletedQuestsDiff(
                curr.Quests,
                prev.Quests
            );

            diff.Hireling = HirelingDiff.GetDiff(
                curr.Hireling,
                prev.Hireling
            );

            if (curr.KilledMonsters != null && curr.KilledMonsters.Count > 0)
            {
                diff.KilledMonsters = curr.KilledMonsters;
            }

            hasDiff = hasDiff
                || diff.AddedItems != null
                || diff.RemovedItems != null
                || diff.Skills != null
                || diff.CompletedQuests != null
                || diff.Hireling != null
                || diff.KilledMonsters != null;

            if (hasDiff)
            {
                diff.Event = curr.Event;
                diff.Name = curr.Name;
                diff.Guid = curr.Guid;

                // always send application info, if something is sent
                diff.DIApplicationInfo = curr.DIApplicationInfo;

                // always send d2 info, if something is sent
                diff.D2ProcessInfo = curr.D2ProcessInfo;

                return diff;
            }

            return null;
        }
    }

    class ProcessInfoConverter : JsonConverter
    {
        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer
        ) {
            JToken t = JToken.FromObject(value);
            if (t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
                return;
            }

            var info = (ProcessInfo)value;
            JObject o = new JObject();
            o.Add("Type", info.ReadableType());
            o.Add("Version", info.ReadableVersion());
            o.Add("CommandLineArgs", new JArray(info.CommandLineArgs));
            o.WriteTo(writer);
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer
        ) {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ProcessInfo);
        }

        public override bool CanRead
        {
            get { return false; }
        }
    }

    class DIApplicationInfoConverter : JsonConverter
    {
        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer
        ) {
            JToken t = JToken.FromObject(value);
            if (t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
                return;
            }

            var info = (IApplicationInfo)value;
            JObject o = new JObject();
            o.Add("Version", info.Version);
            o.WriteTo(writer);
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer
        ) {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IApplicationInfo);
        }

        public override bool CanRead
        {
            get { return false; }
        }
    }
    // A comparer class to determine if two instances of QuestCompletionDetails are equal.
    class QuestCompletionDetailsComparer : IEqualityComparer<QuestCompletionDetails>
    {
        public bool Equals(QuestCompletionDetails x, QuestCompletionDetails y)
        {
            // Check whether the objects are the same object.
            if (Object.ReferenceEquals(x, y)) return true;

            // Check whether the quest details' properties are equal.
            return x != null && y != null &&
                   x.Id == y.Id &&
                   x.Name == y.Name &&
                   x.CompletionBits == y.CompletionBits &&
                   x.IsCompleted == y.IsCompleted &&
                   x.CompletedBits.SequenceEqual(y.CompletedBits);
        }

        public int GetHashCode(QuestCompletionDetails obj)
        {
            // Get the hash code for the Name field if it is not null.
            int hashName = obj.Name == null ? 0 : obj.Name.GetHashCode();

            // Get the hash code for the CompletedBits field.
            int hashCompletedBits = obj.CompletedBits.GetHashCode();

            // Calculate the hash code for the product.
            return hashName ^ hashCompletedBits;
        }
    }
}

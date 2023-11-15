using System.Runtime.InteropServices;

namespace Zutatensuppe.D2Reader.Struct.Item
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1, Size = 0x1A8)]
    public class D2ItemDescription
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        [ExpectOffset(0x000)] public string flippyFile;                   // 0x000
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        [ExpectOffset(0x020)] public string invFile;                      // 0x020
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        [ExpectOffset(0x040)] public string uniqueInvFile;                // 0x040
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        [ExpectOffset(0x060)] public string setInvFile;                   // 0x060
        [ExpectOffset(0x080)] public uint code;                           // 0x080
        [ExpectOffset(0x084)] public uint normCode;                       // 0x084
        [ExpectOffset(0x088)] public uint uberCode;                       // 0x088
        [ExpectOffset(0x08C)] public uint ultraCode;                      // 0x08C
        [ExpectOffset(0x090)] public uint alternateGfx;                   // 0x090
        [ExpectOffset(0x094)] public uint spell;                          // 0x094
        [ExpectOffset(0x098)] public ushort state0;                       // 0x098
        [ExpectOffset(0x09A)] public ushort state1;                       // 0x09A
        [ExpectOffset(0x09C)] public ushort state2;                       // 0x09C
        [ExpectOffset(0x09E)] public ushort stat1;                        // 0x09E
        [ExpectOffset(0x0A0)] public ushort stat2;                        // 0x0A0
        [ExpectOffset(0x0A2)] public ushort stat3;                        // 0x0A2
        [ExpectOffset(0x0A4)] public uint calc1;                          // 0x0A4
        [ExpectOffset(0x0A8)] public uint calc2;                          // 0x0A8
        [ExpectOffset(0x0AC)] public uint calc3;                          // 0x0AC
        [ExpectOffset(0x0B0)] public uint length;                         // 0x0B0
        [ExpectOffset(0x0B4)] public ushort spellDescription;             // 0x0B4
        [ExpectOffset(0x0B6)] public ushort spellDescString;              // 0x0B6
        [ExpectOffset(0x0B8)] public uint spellDescCalc;                  // 0x0B8
        [ExpectOffset(0x0BC)] public uint betterGem;                      // 0x0BC
        [ExpectOffset(0x0C0)] public uint weaponClass;                    // 0x0C0
        [ExpectOffset(0x0C4)] public uint weaponClassTwoHand;             // 0x0C4
        [ExpectOffset(0x0C8)] public uint TMogType;                       // 0x0C8
        [ExpectOffset(0x0CC)] public uint minAC;                          // 0x0CC
        [ExpectOffset(0x0D0)] public uint maxAC;                          // 0x0D0
        [ExpectOffset(0x0D4)] public uint gambleCost;                     // 0x0D4
        [ExpectOffset(0x0D8)] public uint speed;                          // 0x0D8
        [ExpectOffset(0x0DC)] public uint bitField1;                      // 0x0DC
        [ExpectOffset(0x0E0)] public uint cost;                           // 0x0E0
        [ExpectOffset(0x0E4)] public uint minStack;                       // 0x0E4
        [ExpectOffset(0x0E8)] public uint maxStack;                       // 0x0E8
        [ExpectOffset(0x0EC)] public uint spawnStack;                     // 0x0EC
        [ExpectOffset(0x0F0)] public uint gemOffset;                      // 0x0F0
        [ExpectOffset(0x0F4)] public ushort NameHashCode;                 // 0x0F4
        [ExpectOffset(0x0F6)] public ushort version;                      // 0x0F6
        [ExpectOffset(0x0F8)] public ushort autoPrefix;                   // 0x0F8
        [ExpectOffset(0x0FA)] public ushort missileType;                  // 0x0FA
        [ExpectOffset(0x0FC)] public byte rarity;                         // 0x0FC
        [ExpectOffset(0x0FD)] public byte level;                          // 0x0FD
        [ExpectOffset(0x0FE)] public byte minDamage;                      // 0x0FE
        [ExpectOffset(0x0FF)] public byte maxDamage;                      // 0x0FF
        [ExpectOffset(0x100)] public byte minMissDamage;                  // 0x100
        [ExpectOffset(0x101)] public byte maxMissDamage;                  // 0x101
        [ExpectOffset(0x102)] public byte minDamageTwoHand;               // 0x102
        [ExpectOffset(0x103)] public byte maxDamageTwoHand;               // 0x103
        [ExpectOffset(0x104)] public ushort rangeAdder;                   // 0x104
        [ExpectOffset(0x106)] public ushort strBonus;                     // 0x106
        [ExpectOffset(0x108)] public ushort dexBonus;                     // 0x108
        [ExpectOffset(0x10A)] public ushort reqStr;                       // 0x10A
        [ExpectOffset(0x10C)] public ushort reqDex;                       // 0x10C
        [ExpectOffset(0x10E)] public byte absorbs;                        // 0x10E
        [ExpectOffset(0x10F)] public byte invWidth;                       // 0x10F
        [ExpectOffset(0x110)] public byte invHeight;                      // 0x110
        [ExpectOffset(0x111)] public byte block;                          // 0x111
        [ExpectOffset(0x112)] public byte durability;                     // 0x112
        [ExpectOffset(0x113)] public byte noDurability;                   // 0x113
        [ExpectOffset(0x114)] public byte missile;                        // 0x114
        [ExpectOffset(0x115)] public byte component;                      // 0x115
        [ExpectOffset(0x116)] public byte lArm;                           // 0x116
        [ExpectOffset(0x117)] public byte rArm;                           // 0x117
        [ExpectOffset(0x118)] public byte torso;                          // 0x118
        [ExpectOffset(0x119)] public byte legs;                           // 0x119
        [ExpectOffset(0x11A)] public byte lSpad;                          // 0x11A
        [ExpectOffset(0x11B)] public byte rSpad;                          // 0x11B
        [ExpectOffset(0x11C)] public byte TwoHanded;                      // 0x11C
        [ExpectOffset(0x11D)] public byte Usable;                         // 0x11D
        [ExpectOffset(0x11E)] public ushort ItemType;                     // 0x11E
        [ExpectOffset(0x120)] public ushort ItemType2;                    // 0x120
        [ExpectOffset(0x122)] public ushort ItemSubType;                  // 0x122
        [ExpectOffset(0x124)] public ushort DropSound;                    // 0x124
        [ExpectOffset(0x126)] public ushort UseSound;                     // 0x126
        [ExpectOffset(0x128)] public byte DropsFxFrame;                   // 0x128
        [ExpectOffset(0x129)] public byte Unique;                         // 0x129
        [ExpectOffset(0x12A)] public byte Quest;                          // 0x12A
        [ExpectOffset(0x12B)] public byte QuestDiffCheck;                 // 0x12B
        [ExpectOffset(0x12C)] public byte Transparent;                    // 0x12C
        [ExpectOffset(0x12D)] public byte TransTbl;                       // 0x12D
        [ExpectOffset(0x12E)] public byte _1;                             // 0x12E
        [ExpectOffset(0x12F)] public byte LightRadius;                    // 0x12F
        [ExpectOffset(0x130)] public byte Belt;                           // 0x130
        [ExpectOffset(0x131)] public byte AutoBelt;                       // 0x131
        [ExpectOffset(0x132)] public byte Stackable;                      // 0x132
        [ExpectOffset(0x133)] public byte Spawnable;                      // 0x133
        [ExpectOffset(0x134)] public byte SpellIcon;                      // 0x134
        [ExpectOffset(0x135)] public byte DurabilityWarning;              // 0x135
        [ExpectOffset(0x136)] public byte QuantityWarning;                // 0x136
        [ExpectOffset(0x137)] public byte HasInventory;                   // 0x137
        [ExpectOffset(0x138)] public byte GemSockets;                     // 0x138
        [ExpectOffset(0x139)] public byte Transmogrify;                   // 0x139
        [ExpectOffset(0x13A)] public byte TransmogrifyMin;                // 0x13A
        [ExpectOffset(0x13B)] public byte TransmogrifyMax;                // 0x13B
        [ExpectOffset(0x13C)] public byte HitClass;                       // 0x13C
        [ExpectOffset(0x13D)] public byte OneOrTwoHanded;                 // 0x13D
        [ExpectOffset(0x13E)] public byte GemApplyType;                   // 0x13E
        [ExpectOffset(0x13F)] public byte LevelRequirement;               // 0x13F
        [ExpectOffset(0x140)] public byte MagicLevel;                     // 0x140
        [ExpectOffset(0x141)] public byte Transform;                      // 0x141
        [ExpectOffset(0x142)] public byte InvTransform;                   // 0x142
        [ExpectOffset(0x143)] public byte CompactSave;                    // 0x143
        [ExpectOffset(0x144)] public byte SkipName;                       // 0x144
        [ExpectOffset(0x145)] public byte Nameable;                       // 0x145
        [ExpectOffset(0x146)] public byte AkaraMin;                       // 0x146
        [ExpectOffset(0x147)] public byte GheedMin;                       // 0x147
        [ExpectOffset(0x148)] public byte CharsiMin;                      // 0x148
        [ExpectOffset(0x149)] public byte FaraMin;                        // 0x149
        [ExpectOffset(0x14A)] public byte LysanderMin;                    // 0x14A
        [ExpectOffset(0x14B)] public byte DrognanMin;                     // 0x14B
        [ExpectOffset(0x14C)] public byte HraltiMin;                      // 0x14C
        [ExpectOffset(0x14D)] public byte AlkorMin;                       // 0x14D
        [ExpectOffset(0x14E)] public byte OrmusMin;                       // 0x14E
        [ExpectOffset(0x14F)] public byte ElzixMin;                       // 0x14F
        [ExpectOffset(0x150)] public byte AshearaMin;                     // 0x150
        [ExpectOffset(0x151)] public byte CainMin;                        // 0x151
        [ExpectOffset(0x152)] public byte HalbuMin;                       // 0x152
        [ExpectOffset(0x153)] public byte JamellaMin;                     // 0x153
        [ExpectOffset(0x154)] public byte MalahMin;                       // 0x154
        [ExpectOffset(0x155)] public byte LarzukMin;                      // 0x155
        [ExpectOffset(0x156)] public byte DrehyaMin;                      // 0x156
        [ExpectOffset(0x157)] public byte AkaraMax;                       // 0x157
        [ExpectOffset(0x158)] public byte GheedMax;                       // 0x158
        [ExpectOffset(0x159)] public byte CharsiMax;                      // 0x159
        [ExpectOffset(0x15A)] public byte FaraMax;                        // 0x15A
        [ExpectOffset(0x15B)] public byte LysanderMax;                    // 0x15B
        [ExpectOffset(0x15C)] public byte DrognanMax;                     // 0x15C
        [ExpectOffset(0x15D)] public byte HraltiMax;                      // 0x15D
        [ExpectOffset(0x15E)] public byte AlkorMax;                       // 0x15E
        [ExpectOffset(0x15F)] public byte OrmusMax;                       // 0x15F
        [ExpectOffset(0x160)] public byte ElzixMax;                       // 0x160
        [ExpectOffset(0x161)] public byte AshearaMax;                     // 0x161
        [ExpectOffset(0x162)] public byte CainMax;                        // 0x162
        [ExpectOffset(0x163)] public byte HalbuMax;                       // 0x163
        [ExpectOffset(0x164)] public byte JamellaMax;                     // 0x164
        [ExpectOffset(0x165)] public byte MalahMax;                       // 0x165
        [ExpectOffset(0x166)] public byte LarzukMax;                      // 0x166
        [ExpectOffset(0x167)] public byte DrehyaMax;                      // 0x167
        [ExpectOffset(0x168)] public byte AkaraMagicMin;                  // 0x168
        [ExpectOffset(0x169)] public byte GheedMagicMin;                  // 0x169
        [ExpectOffset(0x16A)] public byte CharsiMagicMin;                 // 0x16A
        [ExpectOffset(0x16B)] public byte FaraMagicMin;                   // 0x16B
        [ExpectOffset(0x16C)] public byte LysanderMagicMin;               // 0x16C
        [ExpectOffset(0x16D)] public byte DrognanMagicMin;                // 0x16D
        [ExpectOffset(0x16E)] public byte HraltiMagicMin;                 // 0x16E
        [ExpectOffset(0x16F)] public byte AlkorMagicMin;                  // 0x16F
        [ExpectOffset(0x170)] public byte OrmusMagicMin;                  // 0x170
        [ExpectOffset(0x171)] public byte ElzixMagicMin;                  // 0x171
        [ExpectOffset(0x172)] public byte AshearaMagicMin;                // 0x172
        [ExpectOffset(0x173)] public byte CainMagicMin;                   // 0x173
        [ExpectOffset(0x174)] public byte HalbuMagicMin;                  // 0x174
        [ExpectOffset(0x175)] public byte JamellaMagicMin;                // 0x175
        [ExpectOffset(0x176)] public byte MalahMagicMin;                  // 0x176
        [ExpectOffset(0x177)] public byte LarzukMagicMin;                 // 0x177
        [ExpectOffset(0x178)] public byte DrehyaMagicMin;                 // 0x178
        [ExpectOffset(0x179)] public byte AkaraMagicMax;                  // 0x179
        [ExpectOffset(0x17A)] public byte GheedMagicMax;                  // 0x17A
        [ExpectOffset(0x17B)] public byte CharsiMagicMax;                 // 0x17B
        [ExpectOffset(0x17C)] public byte FaraMagicMax;                   // 0x17C
        [ExpectOffset(0x17D)] public byte LysanderMagicMax;               // 0x17D
        [ExpectOffset(0x17E)] public byte DrognanMagicMax;                // 0x17E
        [ExpectOffset(0x17F)] public byte HraltiMagicMax;                 // 0x17F
        [ExpectOffset(0x180)] public byte AlkorMagicMax;                  // 0x180
        [ExpectOffset(0x181)] public byte OrmusMagicMax;                  // 0x181
        [ExpectOffset(0x182)] public byte ElzixMagicMax;                  // 0x182
        [ExpectOffset(0x183)] public byte AshearaMagicMax;                // 0x183
        [ExpectOffset(0x184)] public byte CainMagicMax;                   // 0x184
        [ExpectOffset(0x185)] public byte HalbuMagicMax;                  // 0x185
        [ExpectOffset(0x186)] public byte JamellaMagicMax;                // 0x186
        [ExpectOffset(0x187)] public byte MalahMagicMax;                  // 0x187
        [ExpectOffset(0x188)] public byte LarzukMagicMax;                 // 0x188
        [ExpectOffset(0x189)] public byte DrehyaMagicMax;                 // 0x189
        [ExpectOffset(0x18A)] public byte AkaraMagicLvl;                  // 0x18A
        [ExpectOffset(0x18B)] public byte GheedMagicLvl;                  // 0x18B
        [ExpectOffset(0x18C)] public byte CharsiMagicLvl;                 // 0x18C
        [ExpectOffset(0x18D)] public byte FaraMagicLvl;                   // 0x18D
        [ExpectOffset(0x18E)] public byte LysanderMagicLvl;               // 0x18E
        [ExpectOffset(0x18F)] public byte DrognanMagicLvl;                // 0x18F
        [ExpectOffset(0x190)] public byte HraltiMagicLvl;                 // 0x190
        [ExpectOffset(0x191)] public byte AlkorMagicLvl;                  // 0x191
        [ExpectOffset(0x192)] public byte OrmusMagicLvl;                  // 0x192
        [ExpectOffset(0x193)] public byte ElzixMagicLvl;                  // 0x193
        [ExpectOffset(0x194)] public byte AshearaMagicLvl;                // 0x194
        [ExpectOffset(0x195)] public byte CainMagicLvl;                   // 0x195
        [ExpectOffset(0x196)] public byte HalbuMagicLvl;                  // 0x196
        [ExpectOffset(0x197)] public byte JamellaMagicLvl;                // 0x197
        [ExpectOffset(0x198)] public byte MalahMagicLvl;                  // 0x198
        [ExpectOffset(0x199)] public byte LarzukMagicLvl;                 // 0x199
        [ExpectOffset(0x19A)] public ushort bDrehyaMagicLvl;              // 0x19A
        [ExpectOffset(0x19C)] public uint dwNightmareUpgrade;             // 0x19C
        [ExpectOffset(0x1A0)] public uint dwHellUpgrade;                  // 0x1A0
        [ExpectOffset(0x1A4)] public byte bPermStoreItem;                 // 0x1A4
        [ExpectOffset(0x1A5)] public byte bmultibuy;                      // 0x1A5
        [ExpectOffset(0x1A6)] public ushort __padding;                    // 0x1A6
    }
}
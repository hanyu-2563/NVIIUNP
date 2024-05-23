﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace NvlUnity.V1
{
    /// <summary>
    /// V1版加密
    /// </summary>
    internal abstract class NVLUnityV1 : IKeyInformationV1
    {
        public abstract byte[] Header { get; }
        public abstract byte[] XorKey { get; }
    }

    /// <summary>
    /// UnityFS  5.x.x 2018.4.0f1 版本
    /// </summary>
    internal abstract class NVLUnityV100 : NVLUnityV1
    {
        public sealed override byte[] Header { get; } = new byte[]
        {
            0x55, 0x6E, 0x69, 0x74, 0x79, 0x46, 0x53, 0x00, 0x00, 0x00, 0x00, 0x06, 0x35, 0x2E, 0x78, 0x2E,
            0x78, 0x00, 0x32, 0x30, 0x31, 0x38, 0x2E, 0x34, 0x2E, 0x30, 0x66, 0x31, 0x00, 0x00, 0x00, 0x00
        };
    }

    /// <summary>
    /// UnityFS  5.x.x 2018.4.26f1 版本
    /// </summary>
    internal abstract class NVLUnityV101 : NVLUnityV1
    {
        public sealed override byte[] Header { get; } = new byte[]
        {
            0x55, 0x6E, 0x69, 0x74, 0x79, 0x46, 0x53, 0x00, 0x00, 0x00, 0x00, 0x06, 0x35, 0x2E, 0x78, 0x2E,
            0x78, 0x00, 0x32, 0x30, 0x31, 0x38, 0x2E, 0x34, 0x2E, 0x32, 0x36, 0x66, 0x31, 0x00, 0x00, 0x00
        };

    }

    //*******************************************下面为游戏**********************************************//


    /// <summary>
    /// 昙花
    /// </summary>
    internal class EpiphyllumInLove : NVLUnityV100
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x13, 0x97, 0x69, 0x3C, 0x12, 0x29, 0xD3, 0xB7, 0x8F, 0x53, 0x4C, 0x7E
        };
    }

    /// <summary>
    /// 梦末
    /// </summary>
    internal class DreamEnding : NVLUnityV100
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0xA3, 0x34, 0x55, 0xCC, 0xB5, 0xDF, 0xF2, 0x9B, 0xD8, 0x4C, 0x77, 0x62
        };
    }

    /// <summary>
    /// 死亡直播间
    /// </summary>
    internal class DeathLive : NVLUnityV100
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x3F, 0xB5, 0x83, 0xA0, 0xC5, 0x45, 0xF8, 0xD6, 0x61, 0x8E, 0x40, 0x9A
        };
    }

    /// <summary>
    /// 青羽
    /// </summary>
    internal class YouthFeather : NVLUnityV100
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0xFC, 0x24, 0x60, 0x38, 0x1F, 0x73, 0xE8, 0xD3, 0x33, 0xAE, 0x41, 0x9A
        };
    }

    /// <summary>
    /// 女装少年短发妹
    /// </summary>
    internal class CrossPrincess : NVLUnityV100
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x8C, 0xFE, 0xC3, 0xF7, 0xE8, 0xE4, 0x3A, 0xA9, 0x54, 0x06, 0xCF, 0x21
        };
    }

    /// <summary>
    /// 茸雪Unity版
    /// </summary>
    internal class TinySnow : NVLUnityV101
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x61, 0xBB, 0x79, 0xA8, 0x62, 0xD0, 0x7E, 0x7D, 0xEA, 0x6B, 0x76, 0xE4
        };
    }


    /// <summary>
    /// 雪中花
    /// </summary>
    internal class FlowerInTheSnow : NVLUnityV101
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x43, 0xCF, 0x8C, 0x9F, 0xA6, 0xA1, 0x1C, 0x84, 0xEC, 0x88, 0x7D, 0x39
        };
    }

    /// <summary>
    /// 小白兔电商
    /// </summary>
    internal class BunnyeShop : NVLUnityV101
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x5B, 0xD1, 0x18, 0x3A, 0x81, 0x40, 0xAF, 0x7B, 0x17, 0x2B, 0x75, 0xF3
        };
    }

    /// <summary>
    /// 重启
    /// </summary>
    internal class Reboot : NVLUnityV101
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x07, 0xA0, 0xF8, 0x56, 0xE0, 0x55, 0x19, 0x3E, 0x12, 0x92, 0x99, 0xF2
        };
    }

    /// <summary>
    /// 山茶列车
    /// </summary>
    internal class CamelliaTrain : NVLUnityV101
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0xF4, 0xFB, 0xCD, 0x73, 0x5C, 0xCA, 0xB4, 0xB6, 0x0C, 0x75, 0xC8, 0xEB
        };
    }

    /// <summary>
    /// 流浪小猫单身狗
    /// </summary>
    internal class CrossMaid : NVLUnityV101
    {
        public override byte[] XorKey { get; } = new byte[]
        {
            0x8E, 0x82, 0x78, 0x31, 0x60, 0x9F, 0x7C, 0x5C, 0xBC, 0x53, 0x56, 0xDD
        };
    }


    internal class DataManagerV1
    {
        private static Dictionary<string, NVLUnityV1> mSGameInformation = new(16)
        {
            { "昙花", new EpiphyllumInLove() },
            { "梦末", new DreamEnding() },
            { "死亡直播间", new DeathLive() },
            { "青羽", new YouthFeather() },
            { "女装少年短发妹", new CrossPrincess() },
            { "茸雪", new TinySnow() },
            { "雪中花", new FlowerInTheSnow() },
            { "小白兔电商", new BunnyeShop() },
            { "重启", new Reboot() },
            { "山茶列车", new CamelliaTrain() },
            { "流浪小猫单身狗", new CrossMaid() },
        };
        /// <summary>
        /// 游戏信息
        /// </summary>
        public static Dictionary<string, NVLUnityV1> SGameInformation
        {
            get
            {
                return mSGameInformation;
            }
        }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SagaLib;

namespace SagaDB.Actor
{
    public partial class Buff
    {

        #region Buffs
        public bool 三转机器人攻速上升
        {
            get
            {
                return buffs[8].Test(0x00000001);
            }
            set
            {
                buffs[8].SetValue(0x00000001, value);
            }
        }
        public bool 三转机器人攻速下降
        {
            get
            {
                return buffs[8].Test(0x00000002);
            }
            set
            {
                buffs[8].SetValue(0x00000002, value);
            }
        }
        public bool 三转ウィークネスショット 
        {
            get
            {
                return buffs[8].Test(0x00000004);
            }
            set
            {
                buffs[8].SetValue(0x00000004, value);
            }
        }
        public bool 点火紫火
        {
            get
            {
                return buffs[8].Test(0x00000008);
            }
            set
            {
                buffs[8].SetValue(0x00000008, value);
            }
        }
        public bool Unknow27
        {
            get
            {
                return buffs[8].Test(0x00000010);
            }
            set
            {
                buffs[8].SetValue(0x00000010, value);
            }
        }
        public bool 三转红锤子ウェポンエンハンス

        {
            get
            {
                return buffs[8].Test(0x00000020);
            }
            set
            {
                buffs[8].SetValue(0x00000020, value);
            }
        }
        public bool 三转レトリック
        {
            get
            {
                return buffs[8].Test(0x00000040);
            }
            set
            {
                buffs[8].SetValue(0x00000040, value);
            }
        }
        public bool 师匠的加护
        {
            get
            {
                return buffs[8].Test(0x00000080);
            }
            set
            {
                buffs[8].SetValue(0x00000080, value);
            }
        }
        public bool 三转モンスターチェンジ
        {
            get
            {
                return buffs[8].Test(0x00000100);
            }
            set
            {
                buffs[8].SetValue(0x00000100, value);
            }
        }
        public bool 三转知识的书
        {
            get
            {
                return buffs[8].Test(0x00000200);
            }
            set
            {
                buffs[8].SetValue(0x00000200, value);
            }
        }
        public bool 三转植物寄生
        {
            get
            {
                return buffs[8].Test(0x00000400);
            }
            set
            {
                buffs[8].SetValue(0x00000400, value);
            }
        }
        public bool 三转パクティオ
        {
            get
            {
                return buffs[8].Test(0x00000800);
            }
            set
            {
                buffs[8].SetValue(0x00000800, value);
            }
        }
        public bool 三转アドバンスアビリテイー
        {
            get
            {
                return buffs[8].Test(0x00001000);
            }
            set
            {
                buffs[8].SetValue(0x00001000, value);
            }
        }
        public bool 三转フエンリル
        {
            get
            {
                return buffs[8].Test(0x00002000);
            }
            set
            {
                buffs[8].SetValue(0x00002000, value);
            }
        }
        public bool Blocking
        {
            get
            {
                return buffs[8].Test(0x00004000);
            }
            set
            {
                buffs[8].SetValue(0x00004000, value);
            }
        }

        /// <summary>
        /// 钓鱼状态
        /// </summary>
        public bool FishingState
        {
            get
            {
                return buffs[8].Test(0x00008000);
            }
            set
            {
                buffs[8].SetValue(0x00008000, value);
            }
        }
        public bool 三转せーチウィークポイント
        {
            get
            {
                return buffs[8].Test(0x00010000);
            }
            set
            {
                buffs[8].SetValue(0x00010000, value);
            }
        }
        public bool アートフルトラップ
        {
            get
            {
                return buffs[8].Test(0x00020000);
            }
            set
            {
                buffs[8].SetValue(0x00020000, value);
            }
        }
        public bool マシン能力低下
        {
            get
            {
                return buffs[8].Test(0x00040000);
            }
            set
            {
                buffs[8].SetValue(0x00040000, value);
            }
        }
        public bool 狂気毒
        {
            get
            {
                return buffs[8].Test(0x00080000);
            }
            set
            {
                buffs[8].SetValue(0x00080000, value);
            }
        }
        public bool フィットアロー
        {
            get
            {
                return buffs[8].Test(0x00100000);
            }
            set
            {
                buffs[8].SetValue(0x00100000, value);
            }
        }
        public bool 全軍突撃
        {
            get
            {
                return buffs[8].Test(0x00200000);
            }
            set
            {
                buffs[8].SetValue(0x00200000, value);
            }
        }
        public bool 流水の構え
        {
            get
            {
                return buffs[8].Test(0x00400000);
            }
            set
            {
                buffs[8].SetValue(0x00400000, value);
            }
        }
        public bool ウィスプオーラ
        {
            get
            {
                return buffs[8].Test(0x00800000);
            }
            set
            {
                buffs[8].SetValue(0x00800000, value);
            }
        }
        public bool むてき
        {
            get
            {
                return buffs[8].Test(0x01000000);
            }
            set
            {
                buffs[8].SetValue(0x01000000, value);
            }
        }
        public bool アナザークロニクル
        {
            get
            {
                return buffs[8].Test(0x02000000);
            }
            set
            {
                buffs[8].SetValue(0x02000000, value);
            }
        }
        public bool 追撃
        {
            get
            {
                return buffs[8].Test(0x04000000);
            }
            set
            {
                buffs[8].SetValue(0x04000000, value);
            }
        }
        public bool EXフレア
        {
            get
            {
                return buffs[8].Test(0x08000000);
            }
            set
            {
                buffs[8].SetValue(0x08000000, value);
            }
        }
        public bool マジックテイク
        {
            get
            {
                return buffs[8].Test(0x10000000);
            }
            set
            {
                buffs[8].SetValue(0x10000000, value);
            }
        }
        public bool ダメージアヴォイド
        {
            get
            {
                return buffs[8].Test(0x20000000);
            }
            set
            {
                buffs[8].SetValue(0x20000000, value);
            }
        }
        public bool アルケミータイム
        {
            get
            {
                return buffs[8].Test(0x40000000);
            }
            set
            {
                buffs[8].SetValue(0x40000000, value);
            }
        }
        #endregion
    }
}

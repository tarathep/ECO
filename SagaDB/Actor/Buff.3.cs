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

        /// <summary>
        /// 武器の無属性上昇
        /// </summary>
        public bool WeaponNatureElementUp
        {
            get
            {
                return buffs[2].Test(0x1);
            }
            set
            {
                buffs[2].SetValue(0x1, value);
            }
        }

        /// <summary>
        /// 武器の火属性上昇
        /// </summary>
        public bool WeaponFireElementUp
        {
            get
            {
                return buffs[2].Test(0x2);
            }
            set
            {
                buffs[2].SetValue(0x2, value);
            }
        }

        /// <summary>
        /// 武器の水属性上昇
        /// </summary>
        public bool WeaponWaterElementUp
        {
            get
            {
                return buffs[2].Test(0x4);
            }
            set
            {
                buffs[2].SetValue(0x4, value);
            }
        }

        /// <summary>
        /// 武器の水属性上昇
        /// </summary>
        public bool WeaponWindElementUp
        {
            get
            {
                return buffs[2].Test(0x8);
            }
            set
            {
                buffs[2].SetValue(0x8, value);
            }
        }

        /// <summary>
        /// 武器の土属性上昇
        /// </summary>
        public bool WeaponEarthElementUp
        {
            get
            {
                return buffs[2].Test(0x10);
            }
            set
            {
                buffs[2].SetValue(0x10, value);
            }
        }

        /// <summary>
        /// 武器の光属性上昇
        /// </summary>
        public bool WeaponHolyElementUp
        {
            get
            {
                return buffs[2].Test(0x20);
            }
            set
            {
                buffs[2].SetValue(0x20, value);
            }
        }

        /// <summary>
        /// 武器の闇属性上昇
        /// </summary>
        public bool WeaponDarkElementUp
        {
            get
            {
                return buffs[2].Test(0x40);
            }
            set
            {
                buffs[2].SetValue(0x40, value);
            }
        }

        /// <summary>
        /// 武器の無属性減少
        /// </summary>
        public bool WeaponNatureElementDown
        {
            get
            {
                return buffs[2].Test(0x00000080);
            }
            set
            {
                buffs[2].SetValue(0x00000080, value);
            }
        }

        /// <summary>
        /// 武器の火属性減少
        /// </summary>
        public bool WeaponFireElementDown
        {
            get
            {
                return buffs[2].Test(0x00000100);
            }
            set
            {
                buffs[2].SetValue(0x00000100, value);
            }
        }

        /// <summary>
        /// 武器の水属性減少
        /// </summary>
        public bool WeaponWaterElementDown
        {
            get
            {
                return buffs[2].Test(0x00000200);
            }
            set
            {
                buffs[2].SetValue(0x00000200, value);
            }
        }

        /// <summary>
        /// 武器の風属性減少
        /// </summary>
        public bool WeaponWindElementDown
        {
            get
            {
                return buffs[2].Test(0x00000400);
            }
            set
            {
                buffs[2].SetValue(0x00000400, value);
            }
        }

        /// <summary>
        /// 武器の土属性減少
        /// </summary>
        public bool WeaponEarthElementDown
        {
            get
            {
                return buffs[2].Test(0x00000800);
            }
            set
            {
                buffs[2].SetValue(0x00000800, value);
            }
        }

        /// <summary>
        /// 武器の光属性減少
        /// </summary>
        public bool WeaponLightElementDown
        {
            get
            {
                return buffs[2].Test(0x00001000);
            }
            set
            {
                buffs[2].SetValue(0x00001000, value);
            }
        }

        /// <summary>
        /// 武器の闇属性減少
        /// </summary>
        public bool WeaponDarkElementDown
        {
            get
            {
                return buffs[2].Test(0x00002000);
            }
            set
            {
                buffs[2].SetValue(0x00002000, value);
            }
        }

        /// <summary>
        /// 体の無属性上昇
        /// </summary>
        public bool BodyNatureElementUp
        {
            get
            {
                return buffs[2].Test(0x4000);
            }
            set
            {
                buffs[2].SetValue(0x4000, value);
            }
        }

        /// <summary>
        /// 体の火属性上昇
        /// </summary>
        public bool BodyFireElementUp
        {
            get
            {
                return buffs[2].Test(0x8000);
            }
            set
            {
                buffs[2].SetValue(0x8000, value);
            }
        }

        /// <summary>
        /// 体の水属性上昇
        /// </summary>
        public bool BodyWaterElementUp
        {
            get
            {
                return buffs[2].Test(0x10000);
            }
            set
            {
                buffs[2].SetValue(0x10000, value);
            }
        }

        /// <summary>
        /// 体の風属性上昇
        /// </summary>
        public bool BodyWindElementUp
        {
            get
            {
                return buffs[2].Test(0x20000);
            }
            set
            {
                buffs[2].SetValue(0x20000, value);
            }
        }

        /// <summary>
        /// 体の土属性上昇
        /// </summary>
        public bool BodyEarthElementUp
        {
            get
            {
                return buffs[2].Test(0x40000);
            }
            set
            {
                buffs[2].SetValue(0x40000, value);
            }
        }

        /// <summary>
        /// 体の光属性上昇
        /// </summary>
        public bool BodyHolyElementUp
        {
            get
            {
                return buffs[2].Test(0x80000);
            }
            set
            {
                buffs[2].SetValue(0x80000, value);
            }
        }

        /// <summary>
        /// 体の闇属性上昇
        /// </summary>
        public bool BodyDarkElementUp
        {
            get
            {
                return buffs[2].Test(0x100000);
            }
            set
            {
                buffs[2].SetValue(0x100000, value);
            }
        }

        /// <summary>
        /// 体の無属性減少
        /// </summary>
        public bool BodyNatureElementDown
        {
            get
            {
                return buffs[2].Test(0x00200000);
            }
            set
            {
                buffs[2].SetValue(0x00200000, value);
            }
        }

        /// <summary>
        /// 体の火属性減少
        /// </summary>
        public bool BodyFireElementDown
        {
            get
            {
                return buffs[2].Test(0x00400000);
            }
            set
            {
                buffs[2].SetValue(0x00400000, value);
            }
        }

        /// <summary>
        /// 体の火属性減少
        /// </summary>
        public bool BodyWaterElementDown
        {
            get
            {
                return buffs[2].Test(0x100000);
            }
            set
            {
                buffs[2].SetValue(0x100000, value);
            }
        }

        /// <summary>
        /// 体の風属性減少
        /// </summary>
        public bool BodyWindElementDown
        {
            get
            {
                return buffs[2].Test(0x01000000);
            }
            set
            {
                buffs[2].SetValue(0x01000000, value);
            }
        }

        /// <summary>
        /// 体の土属性減少
        /// </summary>
        public bool BodyEarthElementDown
        {
            get
            {
                return buffs[2].Test(0x02000000);
            }
            set
            {
                buffs[2].SetValue(0x02000000, value);
            }
        }

        /// <summary>
        /// 体の光属性減少
        /// </summary>
        public bool BodyLightElementDown
        {
            get
            {
                return buffs[2].Test(0x04000000);
            }
            set
            {
                buffs[2].SetValue(0x04000000, value);
            }
        }

        /// <summary>
        /// 体の闇属性減少
        /// </summary>
        public bool BodyDarkElementDown
        {
            get
            {
                return buffs[2].Test(0x08000000);
            }
            set
            {
                buffs[2].SetValue(0x08000000, value);
            }
        }

        #endregion

    }
}

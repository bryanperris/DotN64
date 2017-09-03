﻿namespace N64Emu.CPU
{
    public partial class VR4300
    {
        public partial class Coprocessor0
        {
            #region Properties
            public ulong[] Registers { get; } = new ulong[32];

            public ConfigRegister Config { get; }

            public StatusRegister Status { get; }
            #endregion

            #region Constructors
            public Coprocessor0()
            {
                Config = new ConfigRegister(this);
                Status = new StatusRegister(this);
            }
            #endregion

            #region Methods
            public void PowerOnReset()
            {
                Config.ConfigEP = ConfigRegister.EP.D;
                Config.ConfigBE = ConfigRegister.BE.BigEndian;
            }
            #endregion
        }
    }
}
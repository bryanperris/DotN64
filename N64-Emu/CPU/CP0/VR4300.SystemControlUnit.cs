﻿namespace N64Emu.CPU
{
    public partial class VR4300
    {
        public partial class SystemControlUnit
        {
            #region Properties
            public ulong[] Registers { get; } = new ulong[32];

            public ConfigRegister Config { get; }

            public StatusRegister Status { get; }
            #endregion

            #region Constructors
            public SystemControlUnit()
            {
                Config = new ConfigRegister(this);
                Status = new StatusRegister(this);
            }
            #endregion

            #region Methods
            public void PowerOnReset()
            {
                Config.EP = ConfigRegister.TransferDataPattern.D;
                Config.BE = ConfigRegister.Endianness.BigEndian;
            }
            #endregion
        }
    }
}
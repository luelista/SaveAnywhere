﻿// Decompiled with JetBrains decompiler
// Type: Omegasis.SaveAnywhere.Framework.Models.PlayerData
// Assembly: SaveAnywhere, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA1E3B07-AC71-4821-90DC-80822753C1D9
// Assembly location: C:\Users\keren\Desktop\SaveAnywhere1.5\SaveAnywhere.dll

namespace Omegasis.SaveAnywhere.Framework.Models
{
  public class PlayerData
  {
    public int Time { get; set; }

    public CharacterData[] Characters { get; set; }

    public bool IsCharacterSwimming { get; set; }
  }
}

﻿// Decompiled with JetBrains decompiler
// Type: Decrypt.Log
// Assembly: Decrypt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2765FEAE-7833-475D-8D48-4374EDF0542D
// Assembly location: C:\Users\foxov\Desktop\build\bin\Debug\Decrypt.dll

using System.Collections.Generic;

namespace Decrypt
{
  public class Log
  {
    public string Browser { get; set; } = string.Empty;

    public List<BrowserLog> FileList { get; set; } = new List<BrowserLog>();
  }
}

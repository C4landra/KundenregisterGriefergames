// Decompiled with JetBrains decompiler
// Type: Kundenregister.Program
// Assembly: Kundenregister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F85C44D-B1DE-462A-9C61-F7C69C3B3084
// Assembly location: C:\Users\admin\Desktop\C#\Kundenregister\Kundenregister\Kundenregister\bin\Debug\Kundenregister.exe

using System;
using System.Windows.Forms;

namespace Kundenregister
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}

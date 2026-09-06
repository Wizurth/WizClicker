// Copyright Wiz Productions. All Rights Reserved.

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WizClicker
{
//#############################################################################
//##--------------------------------- CLASS ---------------------------------##
//#############################################################################

public static class WAppSettings
{
//#############################################################################
//##------------------------------- SETTINGS --------------------------------##
//#############################################################################

    public static string LocalDataFolderPath
        => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"WizProductions\WizClicker\");
    public const string ConfigFileName = "Config.json";
    public const string LogsFileName = "Logs.txt";

    public const Keys DefaultFireKey = Keys.A;
    public const Keys DefaultSimKey = Keys.LButton;
    public const int DefaultCps = 5;
    public const int MaxCps = 300;

    public static readonly Color ConfirmTextColor_Success = Color.FromArgb(0, 200, 50);
    public static readonly Color ConfirmTextColor_Failed = Color.FromArgb(200, 50, 0);
}
}
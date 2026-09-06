// Copyright Wiz Productions. All Rights Reserved.

using System.Collections.Generic;
using System.Windows.Forms;

namespace WizClicker
{
//#############################################################################
//##--------------------------------- CLASS ---------------------------------##
//#############################################################################

public static class WLoc
{
//#############################################################################
//##----------------------------- LOCALIZATION ------------------------------##
//#############################################################################

    public const string KeyInput_Waiting = "En attente...";
    public const string KeyInput_Empty   = "Aucune touche définie";
    public const string ToolTip_FireKey  = "Changer la touche d'activation";
    public const string ToolTip_SimKey   = "Changer la touche simulée";
    public const string ToolTip_Confirm  = "Enregistrer dans la configuration";
    public const string State_Active     = "Simulation active";
    public const string State_Inactive   = "Simulation inactif";
    public const string Confirm_Success  = "Saisie enregistrée";
    public const string Confirm_Failed   = "Saisie incorrecte, réessayer";

    public static readonly Dictionary<Keys, string> KeyNames = new Dictionary<Keys, string>()
    {
        [Keys.None]          = "None",
        [Keys.LButton]       = "Clic gauche",
        [Keys.RButton]       = "Clic droit",
        [Keys.MButton]       = "Clic molette",
        [Keys.Back]          = "Retour arrière",
        [Keys.Tab]           = "Tabulation",
        [Keys.LineFeed]      = "LineFeed",
        [Keys.Clear]         = "Clear",
        [Keys.Return]        = "Retour arrière",
        [Keys.ShiftKey]      = "Maj",
        [Keys.ControlKey]    = "Control",
        [Keys.Menu]          = "Menu",
        [Keys.Pause]         = "Pause",
        [Keys.Capital]       = "Capital",
        [Keys.KanaMode]      = "KanaMode",
        [Keys.JunjaMode]     = "JunjaMode",
        [Keys.FinalMode]     = "FinalMode",
        [Keys.HanjaMode]     = "HanjaMode",
        [Keys.Escape]        = "Echape",
        [Keys.IMEConvert]    = "IMEConvert",
        [Keys.IMENonconvert] = "IMENonconvert",
        [Keys.IMEAccept]     = "IMEAccept",
        [Keys.IMEModeChange] = "IMEModeChange",
        [Keys.Space]         = "Espace",
        [Keys.Prior]         = "Prior",
        [Keys.Next]          = "Suivant",
        [Keys.End]           = "Précédent",
        [Keys.Home]          = "Début",
        [Keys.Left]          = "Flèche gauche",
        [Keys.Up]            = "Flèche du haut",
        [Keys.Right]         = "Flèche droit",
        [Keys.Down]          = "Flèche du bas",
        [Keys.Select]        = "Selectionner",
        [Keys.Print]         = "Impression Ecran",
        [Keys.Execute]       = "Execute",
        [Keys.Snapshot]      = "Snapshot",
        [Keys.Insert]        = "Insert",
        [Keys.Delete]        = "Suppr",
        [Keys.Help]          = "Help",

        [Keys.D0] = "D0",
        [Keys.D1] = "D1",
        [Keys.D2] = "D2",
        [Keys.D3] = "D3",
        [Keys.D4] = "D4",
        [Keys.D5] = "D5",
        [Keys.D6] = "D6",
        [Keys.D7] = "D7",
        [Keys.D8] = "D8",
        [Keys.D9] = "D9",

        [Keys.A] = "A",
        [Keys.B] = "B",
        [Keys.C] = "C",
        [Keys.D] = "D",
        [Keys.E] = "E",
        [Keys.F] = "F",
        [Keys.G] = "G",
        [Keys.H] = "H",
        [Keys.I] = "I",
        [Keys.J] = "J",
        [Keys.K] = "K",
        [Keys.L] = "L",
        [Keys.M] = "M",
        [Keys.N] = "N",
        [Keys.O] = "O",
        [Keys.P] = "P",
        [Keys.Q] = "Q",
        [Keys.R] = "R",
        [Keys.S] = "S",
        [Keys.T] = "T",
        [Keys.U] = "U",
        [Keys.V] = "V",
        [Keys.W] = "W",
        [Keys.X] = "X",
        [Keys.Y] = "Y",
        [Keys.Z] = "Z",

        [Keys.LWin]  = "Windows Left",
        [Keys.RWin]  = "Windows Right",
        [Keys.Apps]  = "Apps",
        [Keys.Sleep] = "Sleep",

        [Keys.NumPad0] = "Num Pad 0",
        [Keys.NumPad1] = "Num Pad 1",
        [Keys.NumPad2] = "Num Pad 2",
        [Keys.NumPad3] = "Num Pad 3",
        [Keys.NumPad4] = "Num Pad 4",
        [Keys.NumPad5] = "Num Pad 5",
        [Keys.NumPad6] = "Num Pad 6",
        [Keys.NumPad7] = "Num Pad 7",
        [Keys.NumPad8] = "Num Pad 8",
        [Keys.NumPad9] = "Num Pad 9",

        [Keys.Multiply]  = "Multiplier (*)",
        [Keys.Add]       = "Ajouter (+)",
        [Keys.Separator] = "Separator",
        [Keys.Subtract]  = "Soustraire (-)",
        [Keys.Decimal]   = "Point (.)",
        [Keys.Divide]    = "Diviser (/)",

        [Keys.F1]  = "F1",
        [Keys.F2]  = "F2",
        [Keys.F3]  = "F3",
        [Keys.F4]  = "F4",
        [Keys.F5]  = "F5",
        [Keys.F6]  = "F6",
        [Keys.F7]  = "F7",
        [Keys.F8]  = "F8",
        [Keys.F9]  = "F9",
        [Keys.F10] = "F10",
        [Keys.F11] = "F11",
        [Keys.F12] = "F12",
        [Keys.F13] = "F13",
        [Keys.F14] = "F14",
        [Keys.F15] = "F15",
        [Keys.F16] = "F16",
        [Keys.F17] = "F17",
        [Keys.F18] = "F18",
        [Keys.F19] = "F19",
        [Keys.F20] = "F20",
        [Keys.F21] = "F21",
        [Keys.F22] = "F22",
        [Keys.F23] = "F23",
        [Keys.F24] = "F24",

        [Keys.NumLock] = "Ver.Num",
        [Keys.Scroll]  = "Scroll",

        [Keys.LShiftKey]   = "Maj gauche",
        [Keys.RShiftKey]   = "Maj droit",
        [Keys.LControlKey] = "Control gauche",
        [Keys.RControlKey] = "Control droit",
        [Keys.LMenu]       = "LMenu",
        [Keys.RMenu]       = "RMenu",

        [Keys.BrowserBack]      = "BrowserBack",
        [Keys.BrowserForward]   = "BrowserForward",
        [Keys.BrowserRefresh]   = "BrowserRefresh",
        [Keys.BrowserStop]      = "BrowserStop",
        [Keys.BrowserSearch]    = "BrowserSearch",
        [Keys.BrowserFavorites] = "BrowserFavorites",
        [Keys.BrowserHome]      = "BrowserHome",

        [Keys.VolumeMute] = "VolumeMute",
        [Keys.VolumeDown] = "VolumeDown",
        [Keys.VolumeUp]   = "VolumeUp",

        [Keys.MediaNextTrack]     = "MediaNextTrack",
        [Keys.MediaPreviousTrack] = "MediaPreviousTrack",
        [Keys.MediaStop]          = "MediaStop",
        [Keys.MediaPlayPause]     = "MediaPlayPause",

        [Keys.LaunchMail]         = "LaunchMail",
        [Keys.SelectMedia]        = "SelectMedia",
        [Keys.LaunchApplication1] = "LaunchApplication1",
        [Keys.LaunchApplication2] = "LaunchApplication2",

        [Keys.OemSemicolon]     = "Point-virgule (;)",
        [Keys.Oemplus]          = "Égal (=)",
        [Keys.Oemcomma]         = "Virgule (,)",
        [Keys.OemMinus]         = "Tiret (-)",
        [Keys.OemPeriod]        = "Point (.)",
        [Keys.OemQuestion]      = "Slash (/)",
        [Keys.Oemtilde]         = "Accent grave (`)",
        [Keys.OemOpenBrackets]  = "Crochet ouvrant ([)",
        [Keys.OemPipe]          = "Antislash (\\)",
        [Keys.OemCloseBrackets] = "Crochet fermant (])",
        [Keys.OemQuotes]        = "Apostrophe (')",
        [Keys.Oem8]             = "Oem 8",
        [Keys.OemBackslash]     = "Chevrons (< >)",
        [Keys.OemClear]         = "Clear",

        [Keys.ProcessKey] = "ProcessKey",
        [Keys.Packet]     = "Packet",

        [Keys.Attn]     = "Attn",
        [Keys.Crsel]    = "Crsel",
        [Keys.Exsel]    = "Exsel",
        [Keys.EraseEof] = "EraseEof",
        [Keys.Play]     = "Play",
        [Keys.Zoom]     = "Zoom",
        [Keys.NoName]   = "NoName",
        [Keys.Pa1]      = "Pa1",

        [Keys.Shift]   = "Maj",
        [Keys.Control] = "Control",
        [Keys.Alt]     = "Alt",
    };
}
}
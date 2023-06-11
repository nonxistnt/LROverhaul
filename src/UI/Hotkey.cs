using System;
using System.Collections.Generic;
namespace linerider.UI
{
    public enum Hotkey
    {
        None,
        EditorPencilTool,
        EditorLineTool,
        EditorEraserTool,
        EditorSelectTool,
        EditorPanTool,
        EditorQuickPan,
        EditorDragCanvas,

        EditorToolColor1,
        EditorToolColor2,
        EditorToolColor3,
        EditorRemoveLatestLine,
        EditorFocusStart,
        EditorFocusLastLine,
        EditorCycleToolSetting,
        EditorUndo,
        EditorRedo,
        EditorFocusRider,
        EditorFocusFlag,
        EditorCancelTool,
        EditorMoveStart,

        ToolLifeLock,
        ToolAngleLock,
        ToolAxisLock,
        ToolPerpendicularAxisLock,
        ToolLengthLock,
        ToolXYSnap,
        ToolToggleSnap,
        ToolSelectBothJoints,
        ToolToggleOverlay,
        ToolCopy,
        ToolCut,
        ToolPaste,
        ToolDelete,
        ToolCopyValues,
        ToolPasteValues,
        ToolSwitchRed,
        ToolSwitchGreen,
        ToolSwitchBlue,
        ToolAddSelection,
        ToolToggleSelection,
        ToolScaleAspectRatio,
        LineToolFlipLine,

        PlaybackStartSlowmo,
        PlaybackStartIgnoreFlag,
        PlaybackStartGhostFlag,
        PlaybackStart,
        PlaybackStop,
        PlaybackFlag,
        ToggleSlowmo,
        PlaybackZoom,
        PlaybackUnzoom,
        PlaybackSpeedUp,
        PlaybackSpeedDown,
        PlaybackFrameNext,
        PlaybackFramePrev,
        PlaybackIterationNext,
        PlaybackIterationPrev,
        PlaybackTogglePause,
        PlaybackForward,
        PlaybackBackward,
        PlaybackResetCamera,

        PreferenceOnionSkinning,
        PreferenceAllCheckboxSettings,
        PreferenceInvisibleRider,
        PreferenceDrawDebugGrid,
        PreferenceDrawDebugCamera,
        TogglePreviewMode,

        PreferencesWindow,
        GameMenuWindow,
        TrackPropertiesWindow,
        LoadWindow,
        Quicksave,
        SaveAsWindow,
        TriggerMenuWindow,
        LineGeneratorWindow,

        MagicAnimateAdvanceFrame,
        MagicAnimateRecedeFrame,
        MagicAnimateRecedeMultiFrame,

        CopyX0,
        CopyY0,
        CopyX1,
        CopyY1,
        CopyX2,
        CopyY2,
        CopyX3,
        CopyY3,
        CopyX4,
        CopyY4,
        CopyX5,
        CopyY5,
        CopyX6,
        CopyY6,
        CopyX7,
        CopyY7,
        CopyX8,
        CopyY8,
        CopyX9,
        CopyY9
    }

}
/******************************************************************************/
//
//                             DO NOT MODIFY
//          This file has been generated by the UIElementsGenerator tool
//              See StylePropertyUtilGenerator class for details
//
/******************************************************************************/
using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
    internal static partial class StylePropertyUtil
    {
        public const int k_GroupOffset = 16;

        internal static readonly Dictionary<string, StylePropertyId> s_NameToId = new Dictionary<string, StylePropertyId>()
        {
            {"align-content", StylePropertyId.AlignContent},
            {"align-items", StylePropertyId.AlignItems},
            {"align-self", StylePropertyId.AlignSelf},
            {"background-color", StylePropertyId.BackgroundColor},
            {"background-image", StylePropertyId.BackgroundImage},
            {"border-bottom-color", StylePropertyId.BorderBottomColor},
            {"border-bottom-left-radius", StylePropertyId.BorderBottomLeftRadius},
            {"border-bottom-right-radius", StylePropertyId.BorderBottomRightRadius},
            {"border-bottom-width", StylePropertyId.BorderBottomWidth},
            {"border-color", StylePropertyId.BorderColor},
            {"border-left-color", StylePropertyId.BorderLeftColor},
            {"border-left-width", StylePropertyId.BorderLeftWidth},
            {"border-radius", StylePropertyId.BorderRadius},
            {"border-right-color", StylePropertyId.BorderRightColor},
            {"border-right-width", StylePropertyId.BorderRightWidth},
            {"border-top-color", StylePropertyId.BorderTopColor},
            {"border-top-left-radius", StylePropertyId.BorderTopLeftRadius},
            {"border-top-right-radius", StylePropertyId.BorderTopRightRadius},
            {"border-top-width", StylePropertyId.BorderTopWidth},
            {"border-width", StylePropertyId.BorderWidth},
            {"bottom", StylePropertyId.Bottom},
            {"color", StylePropertyId.Color},
            {"cursor", StylePropertyId.Cursor},
            {"display", StylePropertyId.Display},
            {"flex", StylePropertyId.Flex},
            {"flex-basis", StylePropertyId.FlexBasis},
            {"flex-direction", StylePropertyId.FlexDirection},
            {"flex-grow", StylePropertyId.FlexGrow},
            {"flex-shrink", StylePropertyId.FlexShrink},
            {"flex-wrap", StylePropertyId.FlexWrap},
            {"font-size", StylePropertyId.FontSize},
            {"height", StylePropertyId.Height},
            {"justify-content", StylePropertyId.JustifyContent},
            {"left", StylePropertyId.Left},
            {"margin", StylePropertyId.Margin},
            {"margin-bottom", StylePropertyId.MarginBottom},
            {"margin-left", StylePropertyId.MarginLeft},
            {"margin-right", StylePropertyId.MarginRight},
            {"margin-top", StylePropertyId.MarginTop},
            {"max-height", StylePropertyId.MaxHeight},
            {"max-width", StylePropertyId.MaxWidth},
            {"min-height", StylePropertyId.MinHeight},
            {"min-width", StylePropertyId.MinWidth},
            {"opacity", StylePropertyId.Opacity},
            {"overflow", StylePropertyId.Overflow},
            {"padding", StylePropertyId.Padding},
            {"padding-bottom", StylePropertyId.PaddingBottom},
            {"padding-left", StylePropertyId.PaddingLeft},
            {"padding-right", StylePropertyId.PaddingRight},
            {"padding-top", StylePropertyId.PaddingTop},
            {"position", StylePropertyId.Position},
            {"right", StylePropertyId.Right},
            {"text-overflow", StylePropertyId.TextOverflow},
            {"top", StylePropertyId.Top},
            {"-unity-background-image-tint-color", StylePropertyId.UnityBackgroundImageTintColor},
            {"-unity-background-scale-mode", StylePropertyId.UnityBackgroundScaleMode},
            {"-unity-font", StylePropertyId.UnityFont},
            {"-unity-font-style", StylePropertyId.UnityFontStyleAndWeight},
            {"-unity-overflow-clip-box", StylePropertyId.UnityOverflowClipBox},
            {"-unity-slice-bottom", StylePropertyId.UnitySliceBottom},
            {"-unity-slice-left", StylePropertyId.UnitySliceLeft},
            {"-unity-slice-right", StylePropertyId.UnitySliceRight},
            {"-unity-slice-top", StylePropertyId.UnitySliceTop},
            {"-unity-text-align", StylePropertyId.UnityTextAlign},
            {"-unity-text-overflow-position", StylePropertyId.UnityTextOverflowPosition},
            {"visibility", StylePropertyId.Visibility},
            {"white-space", StylePropertyId.WhiteSpace},
            {"width", StylePropertyId.Width}
        };

        public static int GetEnumIntValue(StyleEnumType enumType, string value)
        {
            switch (enumType)
            {
                case StyleEnumType.Align:
                {
                    if (string.Equals(value, "auto", StringComparison.OrdinalIgnoreCase))
                        return (int)Align.Auto;
                    else if (string.Equals(value, "flex-start", StringComparison.OrdinalIgnoreCase))
                        return (int)Align.FlexStart;
                    else if (string.Equals(value, "center", StringComparison.OrdinalIgnoreCase))
                        return (int)Align.Center;
                    else if (string.Equals(value, "flex-end", StringComparison.OrdinalIgnoreCase))
                        return (int)Align.FlexEnd;
                    else if (string.Equals(value, "stretch", StringComparison.OrdinalIgnoreCase))
                        return (int)Align.Stretch;
                    else
                        return 0;
                }

                case StyleEnumType.DisplayStyle:
                {
                    if (string.Equals(value, "flex", StringComparison.OrdinalIgnoreCase))
                        return (int)DisplayStyle.Flex;
                    else if (string.Equals(value, "none", StringComparison.OrdinalIgnoreCase))
                        return (int)DisplayStyle.None;
                    else
                        return 0;
                }

                case StyleEnumType.FlexDirection:
                {
                    if (string.Equals(value, "column", StringComparison.OrdinalIgnoreCase))
                        return (int)FlexDirection.Column;
                    else if (string.Equals(value, "column-reverse", StringComparison.OrdinalIgnoreCase))
                        return (int)FlexDirection.ColumnReverse;
                    else if (string.Equals(value, "row", StringComparison.OrdinalIgnoreCase))
                        return (int)FlexDirection.Row;
                    else if (string.Equals(value, "row-reverse", StringComparison.OrdinalIgnoreCase))
                        return (int)FlexDirection.RowReverse;
                    else
                        return 0;
                }

                case StyleEnumType.FontStyle:
                {
                    if (string.Equals(value, "normal", StringComparison.OrdinalIgnoreCase))
                        return (int)FontStyle.Normal;
                    else if (string.Equals(value, "bold", StringComparison.OrdinalIgnoreCase))
                        return (int)FontStyle.Bold;
                    else if (string.Equals(value, "italic", StringComparison.OrdinalIgnoreCase))
                        return (int)FontStyle.Italic;
                    else if (string.Equals(value, "bold-and-italic", StringComparison.OrdinalIgnoreCase))
                        return (int)FontStyle.BoldAndItalic;
                    else
                        return 0;
                }

                case StyleEnumType.Justify:
                {
                    if (string.Equals(value, "flex-start", StringComparison.OrdinalIgnoreCase))
                        return (int)Justify.FlexStart;
                    else if (string.Equals(value, "center", StringComparison.OrdinalIgnoreCase))
                        return (int)Justify.Center;
                    else if (string.Equals(value, "flex-end", StringComparison.OrdinalIgnoreCase))
                        return (int)Justify.FlexEnd;
                    else if (string.Equals(value, "space-between", StringComparison.OrdinalIgnoreCase))
                        return (int)Justify.SpaceBetween;
                    else if (string.Equals(value, "space-around", StringComparison.OrdinalIgnoreCase))
                        return (int)Justify.SpaceAround;
                    else
                        return 0;
                }

                case StyleEnumType.Overflow:
                {
                    if (string.Equals(value, "visible", StringComparison.OrdinalIgnoreCase))
                        return (int)Overflow.Visible;
                    else if (string.Equals(value, "hidden", StringComparison.OrdinalIgnoreCase))
                        return (int)Overflow.Hidden;
                    else
                        return 0;
                }

                case StyleEnumType.OverflowClipBox:
                {
                    if (string.Equals(value, "padding-box", StringComparison.OrdinalIgnoreCase))
                        return (int)OverflowClipBox.PaddingBox;
                    else if (string.Equals(value, "content-box", StringComparison.OrdinalIgnoreCase))
                        return (int)OverflowClipBox.ContentBox;
                    else
                        return 0;
                }

                case StyleEnumType.OverflowInternal:
                {
                    if (string.Equals(value, "visible", StringComparison.OrdinalIgnoreCase))
                        return (int)OverflowInternal.Visible;
                    else if (string.Equals(value, "hidden", StringComparison.OrdinalIgnoreCase))
                        return (int)OverflowInternal.Hidden;
                    else if (string.Equals(value, "scroll", StringComparison.OrdinalIgnoreCase))
                        return (int)OverflowInternal.Scroll;
                    else
                        return 0;
                }

                case StyleEnumType.Position:
                {
                    if (string.Equals(value, "relative", StringComparison.OrdinalIgnoreCase))
                        return (int)Position.Relative;
                    else if (string.Equals(value, "absolute", StringComparison.OrdinalIgnoreCase))
                        return (int)Position.Absolute;
                    else
                        return 0;
                }

                case StyleEnumType.ScaleMode:
                {
                    if (string.Equals(value, "stretch-to-fill", StringComparison.OrdinalIgnoreCase))
                        return (int)ScaleMode.StretchToFill;
                    else if (string.Equals(value, "scale-and-crop", StringComparison.OrdinalIgnoreCase))
                        return (int)ScaleMode.ScaleAndCrop;
                    else if (string.Equals(value, "scale-to-fit", StringComparison.OrdinalIgnoreCase))
                        return (int)ScaleMode.ScaleToFit;
                    else
                        return 0;
                }

                case StyleEnumType.TextAnchor:
                {
                    if (string.Equals(value, "upper-left", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.UpperLeft;
                    else if (string.Equals(value, "upper-center", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.UpperCenter;
                    else if (string.Equals(value, "upper-right", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.UpperRight;
                    else if (string.Equals(value, "middle-left", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.MiddleLeft;
                    else if (string.Equals(value, "middle-center", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.MiddleCenter;
                    else if (string.Equals(value, "middle-right", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.MiddleRight;
                    else if (string.Equals(value, "lower-left", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.LowerLeft;
                    else if (string.Equals(value, "lower-center", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.LowerCenter;
                    else if (string.Equals(value, "lower-right", StringComparison.OrdinalIgnoreCase))
                        return (int)TextAnchor.LowerRight;
                    else
                        return 0;
                }

                case StyleEnumType.TextOverflow:
                {
                    if (string.Equals(value, "clip", StringComparison.OrdinalIgnoreCase))
                        return (int)TextOverflow.Clip;
                    else if (string.Equals(value, "ellipsis", StringComparison.OrdinalIgnoreCase))
                        return (int)TextOverflow.Ellipsis;
                    else
                        return 0;
                }

                case StyleEnumType.TextOverflowPosition:
                {
                    if (string.Equals(value, "start", StringComparison.OrdinalIgnoreCase))
                        return (int)TextOverflowPosition.Start;
                    else if (string.Equals(value, "middle", StringComparison.OrdinalIgnoreCase))
                        return (int)TextOverflowPosition.Middle;
                    else if (string.Equals(value, "end", StringComparison.OrdinalIgnoreCase))
                        return (int)TextOverflowPosition.End;
                    else
                        return 0;
                }

                case StyleEnumType.Visibility:
                {
                    if (string.Equals(value, "visible", StringComparison.OrdinalIgnoreCase))
                        return (int)Visibility.Visible;
                    else if (string.Equals(value, "hidden", StringComparison.OrdinalIgnoreCase))
                        return (int)Visibility.Hidden;
                    else
                        return 0;
                }

                case StyleEnumType.WhiteSpace:
                {
                    if (string.Equals(value, "normal", StringComparison.OrdinalIgnoreCase))
                        return (int)WhiteSpace.Normal;
                    else if (string.Equals(value, "nowrap", StringComparison.OrdinalIgnoreCase))
                        return (int)WhiteSpace.NoWrap;
                    else
                        return 0;
                }

                case StyleEnumType.Wrap:
                {
                    if (string.Equals(value, "nowrap", StringComparison.OrdinalIgnoreCase))
                        return (int)Wrap.NoWrap;
                    else if (string.Equals(value, "wrap", StringComparison.OrdinalIgnoreCase))
                        return (int)Wrap.Wrap;
                    else if (string.Equals(value, "wrap-reverse", StringComparison.OrdinalIgnoreCase))
                        return (int)Wrap.WrapReverse;
                    else
                        return 0;
                }
            }

            return 0;
        }
    }
}
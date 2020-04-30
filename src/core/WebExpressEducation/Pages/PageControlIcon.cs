﻿using System;
using System.Collections.Generic;
using System.Linq;
using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlIcon : PageControlBase
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlIcon()
            : base("ControlIcon")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Das ControlIcon stellt ein Bild aus einer Systembibliothek oder ein benutzerdefiniertes Bild bereit.";
            Code = "new ControlIcon(Page) { Icon = TypeIcon.At, Color = new PropertyColorText(TypeColorText.Primary) }";

            var enums = new List<TypeIcon>((TypeIcon[])Enum.GetValues(typeof(TypeIcon))).Where(x => x != TypeIcon.None);

            AddExample
            (
                enums.Take(5).Select(x => new ControlIcon(this)
                {
                    Icon = new PropertyIcon(x),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    TextColor = new PropertyColorText(TypeColorText.Dark)
                }).ToArray()
            );

            // Eigenschaften
            AddProperty
            (
               "Icon (System)",
               enums.Select(x => new ControlIcon(this)
               {
                   Icon = new PropertyIcon(x),
                   Title = Enum.GetName(typeof(TypeIcon), x),
                   Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                   TextColor = new PropertyColorText(TypeColorText.Warning)
               }).ToArray()
            );
            
            AddProperty
            (
               "Icon (Benutzerdefiniert)",
               new ControlIcon(this)
               {
                   Icon = new PropertyIcon(Uri.Root.Append("/Assets/img/Icon16.png")),
                   Title = "Rakete",
                   Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                   TextColor = new PropertyColorText(TypeColorText.Primary)
               }
            );

            AddProperty
            (
                "Size",
                new ControlIcon(this)
                {
                    Title = "Extra Small",
                    Size = new PropertySizeText(TypeSizeText.ExtraSmall),
                    Icon = new PropertyIcon(TypeIcon.Home),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlIcon(this)
                {
                    Title = "Small",
                    Size = new PropertySizeText(TypeSizeText.Small),
                    Icon = new PropertyIcon(TypeIcon.Home),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlIcon(this)
                {
                    Title = "Standard",
                    Size = new PropertySizeText(TypeSizeText.Default),
                    Icon = new PropertyIcon(TypeIcon.Home),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlIcon(this)
                {
                    Title = "Large",
                    Size = new PropertySizeText(TypeSizeText.Large),
                    Icon = new PropertyIcon(TypeIcon.Home),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlIcon(this)
                {
                    Title = "Extra Large",
                    Size = new PropertySizeText(TypeSizeText.ExtraLarge),
                    Icon = new PropertyIcon(TypeIcon.Home),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                },
                new ControlIcon(this)
                {
                    Title = "Benutzerdefiniert",
                    Size = new PropertySizeText(3.1f),
                    Icon = new PropertyIcon(TypeIcon.Home),
                    TextColor = new PropertyColorText(TypeColorText.Default),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two)
                }
            );

            AddProperty
            (
                "TextColor",
                enums.Select(x => new ControlIcon(this)
                {
                    Icon = new PropertyIcon(x),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    TextColor = new PropertyColorText(TypeColorText.Primary)
                }).ToArray()
            );

            AddProperty
            (
                "BackgroundColor",
                enums.Select(x => new ControlIcon(this)
                {
                    Icon = new PropertyIcon(x),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    Padding = new PropertySpacingPadding(PropertySpacing.Space.Three),
                    TextColor = new PropertyColorText(TypeColorText.White),
                    BackgroundColor = new PropertyColorBackground(TypeColorBackground.Success)
                }).ToArray()
            );

            AddProperty
            (
                "Title",
                enums.Select(x => new ControlIcon(this)
                {
                    Icon = new PropertyIcon(x),
                    Title = Enum.GetName(typeof(TypeIcon), x),
                    Margin = new PropertySpacingMargin(PropertySpacing.Space.Two),
                    TextColor = new PropertyColorText(TypeColorText.Danger),
                }).ToArray()
            );
        }

        /// <summary>
        /// Verarbeitung
        /// </summary>
        public override void Process()
        {
            base.Process();
        }
    }
}

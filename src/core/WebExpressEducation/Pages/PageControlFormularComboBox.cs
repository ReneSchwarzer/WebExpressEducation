﻿using WebExpress.UI.Controls;

namespace Education.Pages
{
    public class PageControlFormularComboBox : PageControlBase
    {
        /// <summary>
        /// Das Beispielformular
        /// </summary>
        ControlFormularItemInputComboBox combo = new ControlFormularItemInputComboBox
        (
            "combo",
            new ControlFormularItemInputComboBoxItem() { Value = null },
            new ControlFormularItemInputComboBoxItem() { Text = "Hallo Welt!", Value = "1" },
            new ControlFormularItemInputComboBoxItem() { Text = "Hello World!", Value = "2" },
            new ControlFormularItemInputComboBoxItem() { Text = "Всем привет!", Value = "3" },
            new ControlFormularItemInputComboBoxItem() { Text = "ハローワールド！", Value = "4" },
            new ControlFormularItemInputComboBoxItem() { Text = "¡Hola mundo!", Value = "5" }
        )
        {
            Label = "Grüße",
            Icon = new PropertyIcon(TypeIcon.Font),
            Help = "Das ist der zugehörige Hilfetext."
        };

        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlFormularComboBox()
            : base("ControlFormularItemInputComboBox")
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        public override void Init()
        {
            base.Init();

            Description = "Die ControlFormularItemInputComboBox stelt eine ComboBox für Formulareingaben bereit.";
            Code = "new ControlFormularItemInputComboBox \n";
            Code += "(\n";
            Code += "\"combo\",\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Value = null },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"Hallo Welt!\", Value = \"1\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"Hello World!\", Value = \"2\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"Всем привет!\", Value = \"3\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"ハローワールド！\", Value = \"4\" },\n";
            Code += "new ControlFormularItemInputComboBoxItem() { Text = \"¡Hola mundo!\", Value = \"5\" \n";
            Code += "})";

            
            var form = new ControlFormular(combo);
            form.InitFormular += (s, e) => 
            {
                combo.Value = "1";
            };
                                    
            AddExample(form);

            //// Eigenschaften
            //AddProperty
            //(
            //    "Placeholder",
            //    "Legt einen Platzhaltertext fest",
            //    "Placeholder = \"Geben Sie hier einen Wert an!\"",
            //    new ControlFormular(new ControlFormularItemInputComboBox("placeholder") { Placeholder = "Geben Sie hier einen Wert an!" })
            //    {
            //        Layout = TypeLayoutFormular.Inline,
            //        EnableCancelButton = false
            //    }
            //);

            
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

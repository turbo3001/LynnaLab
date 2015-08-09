
// This file has been generated by the GUI designer. Do not modify.
namespace LynnaLab
{
	public partial class AreaEditor
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label label7;
		
		private global::LynnaLab.SpinButtonHexadecimal areaSpinButton;
		
		private global::Gtk.Frame frame2;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.Table table2;
		
		private global::LynnaLab.SpinButtonHexadecimal animationsSpinButton;
		
		private global::LynnaLab.SpinButtonHexadecimal flags1SpinButton;
		
		private global::LynnaLab.SpinButtonHexadecimal flags2SpinButton;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::LynnaLab.SpinButtonHexadecimal layoutGroupSpinButton;
		
		private global::LynnaLab.ComboBoxFromConstants mainGfxComboBox;
		
		private global::LynnaLab.ComboBoxFromConstants palettesComboBox;
		
		private global::LynnaLab.SpinButtonHexadecimal tilesetSpinButton;
		
		private global::LynnaLab.ComboBoxFromConstants uniqueGfxComboBox;
		
		private global::Gtk.Label GtkLabel;
		
		private global::Gtk.Button okButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LynnaLab.AreaEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LynnaLab.AreaEditor";
			// Container child LynnaLab.AreaEditor.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Area");
			this.hbox2.Add (this.label7);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label7]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.areaSpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
			this.areaSpinButton.CanFocus = true;
			this.areaSpinButton.Name = "areaSpinButton";
			this.areaSpinButton.Adjustment.Upper = 255;
			this.areaSpinButton.Adjustment.PageIncrement = 10;
			this.areaSpinButton.Adjustment.StepIncrement = 1;
			this.areaSpinButton.ClimbRate = 1;
			this.areaSpinButton.Digits = ((uint)(2));
			this.areaSpinButton.Numeric = true;
			this.hbox2.Add (this.areaSpinButton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.areaSpinButton]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(8)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.animationsSpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
			this.animationsSpinButton.CanFocus = true;
			this.animationsSpinButton.Name = "animationsSpinButton";
			this.animationsSpinButton.Adjustment.Upper = 100;
			this.animationsSpinButton.Adjustment.PageIncrement = 10;
			this.animationsSpinButton.Adjustment.StepIncrement = 1;
			this.animationsSpinButton.ClimbRate = 1;
			this.animationsSpinButton.Digits = ((uint)(2));
			this.animationsSpinButton.Numeric = true;
			this.table2.Add (this.animationsSpinButton);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.animationsSpinButton]));
			w4.TopAttach = ((uint)(7));
			w4.BottomAttach = ((uint)(8));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.flags1SpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
			this.flags1SpinButton.CanFocus = true;
			this.flags1SpinButton.Name = "flags1SpinButton";
			this.flags1SpinButton.Adjustment.Upper = 255;
			this.flags1SpinButton.Adjustment.PageIncrement = 10;
			this.flags1SpinButton.Adjustment.StepIncrement = 1;
			this.flags1SpinButton.ClimbRate = 1;
			this.flags1SpinButton.Digits = ((uint)(2));
			this.flags1SpinButton.Numeric = true;
			this.table2.Add (this.flags1SpinButton);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.flags1SpinButton]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.flags2SpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
			this.flags2SpinButton.CanFocus = true;
			this.flags2SpinButton.Name = "flags2SpinButton";
			this.flags2SpinButton.Adjustment.Upper = 255;
			this.flags2SpinButton.Adjustment.PageIncrement = 10;
			this.flags2SpinButton.Adjustment.StepIncrement = 1;
			this.flags2SpinButton.ClimbRate = 1;
			this.flags2SpinButton.Digits = ((uint)(2));
			this.flags2SpinButton.Numeric = true;
			this.table2.Add (this.flags2SpinButton);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.flags2SpinButton]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Main Gfx");
			this.table2.Add (this.label1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.label1]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Palettes");
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.label2]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Tileset");
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w9.TopAttach = ((uint)(5));
			w9.BottomAttach = ((uint)(6));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Flags 1");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Flags 2");
			this.table2.Add (this.label5);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.label5]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Unique Gfx");
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w12.TopAttach = ((uint)(2));
			w12.BottomAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Layout Group");
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.label8]));
			w13.TopAttach = ((uint)(6));
			w13.BottomAttach = ((uint)(7));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Animations");
			this.table2.Add (this.label9);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.label9]));
			w14.TopAttach = ((uint)(7));
			w14.BottomAttach = ((uint)(8));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.layoutGroupSpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
			this.layoutGroupSpinButton.CanFocus = true;
			this.layoutGroupSpinButton.Name = "layoutGroupSpinButton";
			this.layoutGroupSpinButton.Adjustment.Upper = 100;
			this.layoutGroupSpinButton.Adjustment.PageIncrement = 10;
			this.layoutGroupSpinButton.Adjustment.StepIncrement = 1;
			this.layoutGroupSpinButton.ClimbRate = 1;
			this.layoutGroupSpinButton.Numeric = true;
			this.table2.Add (this.layoutGroupSpinButton);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.layoutGroupSpinButton]));
			w15.TopAttach = ((uint)(6));
			w15.BottomAttach = ((uint)(7));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.mainGfxComboBox = new global::LynnaLab.ComboBoxFromConstants ();
			this.mainGfxComboBox.Events = ((global::Gdk.EventMask)(256));
			this.mainGfxComboBox.Name = "mainGfxComboBox";
			this.mainGfxComboBox.Active = 0;
			this.table2.Add (this.mainGfxComboBox);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.mainGfxComboBox]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.palettesComboBox = new global::LynnaLab.ComboBoxFromConstants ();
			this.palettesComboBox.Events = ((global::Gdk.EventMask)(256));
			this.palettesComboBox.Name = "palettesComboBox";
			this.palettesComboBox.Active = 0;
			this.table2.Add (this.palettesComboBox);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.palettesComboBox]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.tilesetSpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
			this.tilesetSpinButton.CanFocus = true;
			this.tilesetSpinButton.Name = "tilesetSpinButton";
			this.tilesetSpinButton.Adjustment.Upper = 100;
			this.tilesetSpinButton.Adjustment.PageIncrement = 10;
			this.tilesetSpinButton.Adjustment.StepIncrement = 1;
			this.tilesetSpinButton.ClimbRate = 1;
			this.tilesetSpinButton.Digits = ((uint)(2));
			this.tilesetSpinButton.Numeric = true;
			this.table2.Add (this.tilesetSpinButton);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.tilesetSpinButton]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.uniqueGfxComboBox = new global::LynnaLab.ComboBoxFromConstants ();
			this.uniqueGfxComboBox.Events = ((global::Gdk.EventMask)(256));
			this.uniqueGfxComboBox.Name = "uniqueGfxComboBox";
			this.uniqueGfxComboBox.Active = 0;
			this.table2.Add (this.uniqueGfxComboBox);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table2 [this.uniqueGfxComboBox]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.table2);
			this.frame2.Add (this.GtkAlignment);
			this.GtkLabel = new global::Gtk.Label ();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel;
			this.vbox2.Add (this.frame2);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame2]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.okButton = new global::Gtk.Button ();
			this.okButton.CanFocus = true;
			this.okButton.Name = "okButton";
			this.okButton.UseUnderline = true;
			this.okButton.Label = global::Mono.Unix.Catalog.GetString ("OK");
			this.vbox2.Add (this.okButton);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.okButton]));
			w23.PackType = ((global::Gtk.PackType)(1));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.areaSpinButton.ValueChanged += new global::System.EventHandler (this.OnAreaSpinButtonValueChanged);
			this.uniqueGfxComboBox.Changed += new global::System.EventHandler (this.OnUniqueGfxComboBoxChanged);
			this.palettesComboBox.Changed += new global::System.EventHandler (this.OnPalettesComboBoxChanged);
			this.mainGfxComboBox.Changed += new global::System.EventHandler (this.OnMainGfxComboBoxChanged);
			this.layoutGroupSpinButton.ValueChanged += new global::System.EventHandler (this.OnLayoutGroupSpinButtonValueChanged);
			this.flags1SpinButton.ValueChanged += new global::System.EventHandler (this.OnFlags1SpinButtonValueChanged);
			this.animationsSpinButton.ValueChanged += new global::System.EventHandler (this.OnAnimationsSpinButtonValueChanged);
			this.okButton.Clicked += new global::System.EventHandler (this.OnOkButtonClicked);
		}
	}
}

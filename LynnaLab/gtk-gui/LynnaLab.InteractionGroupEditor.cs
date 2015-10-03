
// This file has been generated by the GUI designer. Do not modify.
namespace LynnaLab
{
	public partial class InteractionGroupEditor
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.SpinButton indexSpinButton;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Button addButton;
		
		private global::Gtk.Button deleteButton;
		
		private global::Gtk.Frame frame2;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.Alignment interactionDataContainer;
		
		private global::Gtk.Label frameLabel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LynnaLab.InteractionGroupEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LynnaLab.InteractionGroupEditor";
			// Container child LynnaLab.InteractionGroupEditor.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Interaction Index");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.indexSpinButton = new global::Gtk.SpinButton (0, 100, 1);
			this.indexSpinButton.Name = "indexSpinButton";
			this.indexSpinButton.Adjustment.PageIncrement = 10;
			this.indexSpinButton.ClimbRate = 1;
			this.indexSpinButton.Numeric = true;
			this.hbox1.Add (this.indexSpinButton);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.indexSpinButton]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.addButton = new global::Gtk.Button ();
			this.addButton.CanFocus = true;
			this.addButton.Name = "addButton";
			this.addButton.UseStock = true;
			this.addButton.UseUnderline = true;
			this.addButton.Label = "gtk-add";
			this.vbox2.Add (this.addButton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.addButton]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.deleteButton = new global::Gtk.Button ();
			this.deleteButton.CanFocus = true;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.UseStock = true;
			this.deleteButton.UseUnderline = true;
			this.deleteButton.Label = "gtk-delete";
			this.vbox2.Add (this.deleteButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.deleteButton]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 0F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.interactionDataContainer = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.interactionDataContainer.Name = "interactionDataContainer";
			this.GtkAlignment.Add (this.interactionDataContainer);
			this.frame2.Add (this.GtkAlignment);
			this.frameLabel = new global::Gtk.Label ();
			this.frameLabel.Name = "frameLabel";
			this.frameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Interaction");
			this.frameLabel.UseMarkup = true;
			this.frame2.LabelWidget = this.frameLabel;
			this.vbox1.Add (this.frame2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame2]));
			w9.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.addButton.Clicked += new global::System.EventHandler (this.OnAddButtonClicked);
			this.deleteButton.Clicked += new global::System.EventHandler (this.OnDeleteButtonClicked);
		}
	}
}

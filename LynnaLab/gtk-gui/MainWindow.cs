
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action OpenAction;
	
	private global::Gtk.Action QuitAction;
	
	private global::Gtk.Action SaveAction;
	
	private global::Gtk.Action ViewAction;
	
	private global::Gtk.ToggleAction AnimationsAction;
	
	private global::Gtk.Action RedrawMinimapsAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.Table table4;
	
	private global::Gtk.Label label3;
	
	private global::LynnaLab.SpinButtonHexadecimal roomSpinButton;
	
	private global::Gtk.Frame frame1;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.Table table3;
	
	private global::Gtk.Button areaEditorButton;
	
	private global::LynnaLab.SpinButtonHexadecimal areaSpinButton;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Label label8;
	
	private global::LynnaLab.ComboBoxFromConstants musicComboBox;
	
	private global::Gtk.Label GtkLabel3;
	
	private global::Gtk.Frame frame2;
	
	private global::Gtk.Alignment GtkAlignment1;
	
	private global::Gtk.VBox vbox6;
	
	private global::Gtk.CheckButton viewInteractionsCheckBox;
	
	private global::LynnaLab.InteractionGroupEditor interactionGroupEditor;
	
	private global::Gtk.Label GtkLabel4;
	
	private global::Gtk.VBox vbox2;
	
	private global::LynnaLab.AreaViewer areaviewer1;
	
	private global::LynnaLab.RoomEditor roomeditor1;
	
	private global::Gtk.Notebook notebook2;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.Table table2;
	
	private global::Gtk.Label label7;
	
	private global::Gtk.SpinButton worldSpinButton;
	
	private global::LynnaLab.Minimap worldMinimap;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.SpinButton dungeonSpinButton;
	
	private global::Gtk.SpinButton floorSpinButton;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Label label2;
	
	private global::LynnaLab.Minimap dungeonMinimap;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.Alignment alignment2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
		w1.Add (this.FileAction, "<Alt>f");
		this.OpenAction = new global::Gtk.Action ("OpenAction", global::Mono.Unix.Catalog.GetString ("_Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Open");
		w1.Add (this.OpenAction, "<Primary>o");
		this.QuitAction = new global::Gtk.Action ("QuitAction", global::Mono.Unix.Catalog.GetString ("_Quit"), null, null);
		this.QuitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Quit");
		w1.Add (this.QuitAction, "<Primary>q");
		this.SaveAction = new global::Gtk.Action ("SaveAction", global::Mono.Unix.Catalog.GetString ("_Save"), null, null);
		this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Save");
		w1.Add (this.SaveAction, "<Primary>s");
		this.ViewAction = new global::Gtk.Action ("ViewAction", global::Mono.Unix.Catalog.GetString ("_View"), null, null);
		this.ViewAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_View");
		w1.Add (this.ViewAction, "<Alt>f");
		this.AnimationsAction = new global::Gtk.ToggleAction ("AnimationsAction", global::Mono.Unix.Catalog.GetString ("_Animations"), null, null);
		this.AnimationsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Animations");
		w1.Add (this.AnimationsAction, "<Primary>a");
		this.RedrawMinimapsAction = new global::Gtk.Action ("RedrawMinimapsAction", global::Mono.Unix.Catalog.GetString ("Redraw Minimaps"), null, null);
		this.RedrawMinimapsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Redraw Minimaps");
		w1.Add (this.RedrawMinimapsAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Lynna Lab");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction' action='SaveAction'/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='ViewAction' action='ViewAction'><menuitem name='AnimationsAction' action='AnimationsAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.table4 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(6));
		this.table4.ColumnSpacing = ((uint)(6));
		// Container child table4.Gtk.Table+TableChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Room");
		this.table4.Add (this.label3);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table4 [this.label3]));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.roomSpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
		this.roomSpinButton.CanFocus = true;
		this.roomSpinButton.Name = "roomSpinButton";
		this.roomSpinButton.Adjustment.Upper = 1535;
		this.roomSpinButton.Adjustment.PageIncrement = 10;
		this.roomSpinButton.Adjustment.StepIncrement = 1;
		this.roomSpinButton.ClimbRate = 1;
		this.roomSpinButton.Digits = ((uint)(2));
		this.roomSpinButton.Numeric = true;
		this.table4.Add (this.roomSpinButton);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table4 [this.roomSpinButton]));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox5.Add (this.table4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.table4]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
		this.table3.Name = "table3";
		this.table3.RowSpacing = ((uint)(6));
		this.table3.ColumnSpacing = ((uint)(6));
		// Container child table3.Gtk.Table+TableChild
		this.areaEditorButton = new global::Gtk.Button ();
		this.areaEditorButton.CanFocus = true;
		this.areaEditorButton.Name = "areaEditorButton";
		this.areaEditorButton.UseUnderline = true;
		this.areaEditorButton.Label = global::Mono.Unix.Catalog.GetString ("Edit");
		this.table3.Add (this.areaEditorButton);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.areaEditorButton]));
		w6.TopAttach = ((uint)(1));
		w6.BottomAttach = ((uint)(2));
		w6.LeftAttach = ((uint)(2));
		w6.RightAttach = ((uint)(3));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.areaSpinButton = new global::LynnaLab.SpinButtonHexadecimal ();
		this.areaSpinButton.CanFocus = true;
		this.areaSpinButton.Name = "areaSpinButton";
		this.areaSpinButton.Adjustment.Upper = 255;
		this.areaSpinButton.Adjustment.PageIncrement = 10;
		this.areaSpinButton.Adjustment.StepIncrement = 1;
		this.areaSpinButton.ClimbRate = 1;
		this.areaSpinButton.Digits = ((uint)(2));
		this.areaSpinButton.Numeric = true;
		this.table3.Add (this.areaSpinButton);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3 [this.areaSpinButton]));
		w7.TopAttach = ((uint)(1));
		w7.BottomAttach = ((uint)(2));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Music");
		this.table3.Add (this.label4);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3 [this.label4]));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Area");
		this.table3.Add (this.label8);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.label8]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.musicComboBox = new global::LynnaLab.ComboBoxFromConstants ();
		this.musicComboBox.Events = ((global::Gdk.EventMask)(256));
		this.musicComboBox.Name = "musicComboBox";
		this.musicComboBox.Active = 0;
		this.table3.Add (this.musicComboBox);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3 [this.musicComboBox]));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment.Add (this.table3);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel3 = new global::Gtk.Label ();
		this.GtkLabel3.Name = "GtkLabel3";
		this.GtkLabel3.LabelProp = global::Mono.Unix.Catalog.GetString ("Room Properties");
		this.GtkLabel3.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel3;
		this.vbox5.Add (this.frame1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame1]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.viewInteractionsCheckBox = new global::Gtk.CheckButton ();
		this.viewInteractionsCheckBox.CanFocus = true;
		this.viewInteractionsCheckBox.Name = "viewInteractionsCheckBox";
		this.viewInteractionsCheckBox.Label = global::Mono.Unix.Catalog.GetString ("View Interactions");
		this.viewInteractionsCheckBox.DrawIndicator = true;
		this.viewInteractionsCheckBox.UseUnderline = true;
		this.viewInteractionsCheckBox.FocusOnClick = false;
		this.vbox6.Add (this.viewInteractionsCheckBox);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.viewInteractionsCheckBox]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.interactionGroupEditor = new global::LynnaLab.InteractionGroupEditor ();
		this.interactionGroupEditor.Events = ((global::Gdk.EventMask)(256));
		this.interactionGroupEditor.Name = "interactionGroupEditor";
		this.vbox6.Add (this.interactionGroupEditor);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.interactionGroupEditor]));
		w15.Position = 1;
		this.GtkAlignment1.Add (this.vbox6);
		this.frame2.Add (this.GtkAlignment1);
		this.GtkLabel4 = new global::Gtk.Label ();
		this.GtkLabel4.Name = "GtkLabel4";
		this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("Interactions");
		this.GtkLabel4.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel4;
		this.vbox5.Add (this.frame2);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frame2]));
		w18.PackType = ((global::Gtk.PackType)(1));
		w18.Position = 2;
		this.hbox1.Add (this.vbox5);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox5]));
		w19.Position = 0;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.areaviewer1 = new global::LynnaLab.AreaViewer ();
		this.areaviewer1.WidthRequest = 256;
		this.areaviewer1.HeightRequest = 256;
		this.areaviewer1.Name = "areaviewer1";
		this.areaviewer1.SelectedIndex = 0;
		this.areaviewer1.Height = 16;
		this.areaviewer1.Width = 16;
		this.areaviewer1.TileWidth = 16;
		this.areaviewer1.TileHeight = 16;
		this.areaviewer1.Scale = 1;
		this.vbox2.Add (this.areaviewer1);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.areaviewer1]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.roomeditor1 = new global::LynnaLab.RoomEditor ();
		this.roomeditor1.WidthRequest = 240;
		this.roomeditor1.HeightRequest = 224;
		this.roomeditor1.Name = "roomeditor1";
		this.roomeditor1.ViewInteractions = false;
		this.roomeditor1.Height = 14;
		this.roomeditor1.Width = 15;
		this.roomeditor1.TileWidth = 16;
		this.roomeditor1.TileHeight = 16;
		this.roomeditor1.Scale = 1;
		this.vbox2.Add (this.roomeditor1);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.roomeditor1]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		this.hbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.hbox1]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.notebook2 = new global::Gtk.Notebook ();
		this.notebook2.CanFocus = true;
		this.notebook2.Name = "notebook2";
		this.notebook2.CurrentPage = 1;
		// Container child notebook2.Gtk.Notebook+NotebookChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.Xalign = 1F;
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("World Index");
		this.table2.Add (this.label7);
		global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.label7]));
		w24.XOptions = ((global::Gtk.AttachOptions)(4));
		w24.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.worldSpinButton = new global::Gtk.SpinButton (0, 100, 1);
		this.worldSpinButton.CanFocus = true;
		this.worldSpinButton.Name = "worldSpinButton";
		this.worldSpinButton.Adjustment.PageIncrement = 10;
		this.worldSpinButton.ClimbRate = 1;
		this.worldSpinButton.Numeric = true;
		this.table2.Add (this.worldSpinButton);
		global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.worldSpinButton]));
		w25.LeftAttach = ((uint)(1));
		w25.RightAttach = ((uint)(2));
		w25.XOptions = ((global::Gtk.AttachOptions)(4));
		w25.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox4.Add (this.table2);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.table2]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.worldMinimap = new global::LynnaLab.Minimap ();
		this.worldMinimap.WidthRequest = 320;
		this.worldMinimap.HeightRequest = 256;
		this.worldMinimap.Name = "worldMinimap";
		this.worldMinimap.Floor = 0;
		this.worldMinimap.SelectedIndex = 0;
		this.worldMinimap.Height = 16;
		this.worldMinimap.Width = 16;
		this.worldMinimap.TileWidth = 20;
		this.worldMinimap.TileHeight = 16;
		this.worldMinimap.Scale = 1;
		this.vbox4.Add (this.worldMinimap);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.worldMinimap]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.notebook2.Add (this.vbox4);
		// Notebook tab
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Worlds");
		this.notebook2.SetTabLabel (this.vbox4, this.label5);
		this.label5.ShowAll ();
		// Container child notebook2.Gtk.Notebook+NotebookChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.dungeonSpinButton = new global::Gtk.SpinButton (0, 100, 1);
		this.dungeonSpinButton.CanFocus = true;
		this.dungeonSpinButton.Name = "dungeonSpinButton";
		this.dungeonSpinButton.Adjustment.PageIncrement = 10;
		this.dungeonSpinButton.ClimbRate = 1;
		this.dungeonSpinButton.Numeric = true;
		this.table1.Add (this.dungeonSpinButton);
		global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.dungeonSpinButton]));
		w29.LeftAttach = ((uint)(1));
		w29.RightAttach = ((uint)(2));
		w29.XOptions = ((global::Gtk.AttachOptions)(4));
		w29.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.floorSpinButton = new global::Gtk.SpinButton (0, 100, 1);
		this.floorSpinButton.CanFocus = true;
		this.floorSpinButton.Name = "floorSpinButton";
		this.floorSpinButton.Adjustment.PageIncrement = 10;
		this.floorSpinButton.ClimbRate = 1;
		this.floorSpinButton.Numeric = true;
		this.table1.Add (this.floorSpinButton);
		global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.floorSpinButton]));
		w30.TopAttach = ((uint)(1));
		w30.BottomAttach = ((uint)(2));
		w30.LeftAttach = ((uint)(1));
		w30.RightAttach = ((uint)(2));
		w30.XOptions = ((global::Gtk.AttachOptions)(4));
		w30.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 1F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Dungeon Index");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
		w31.XOptions = ((global::Gtk.AttachOptions)(4));
		w31.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 1F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Floor");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w32.TopAttach = ((uint)(1));
		w32.BottomAttach = ((uint)(2));
		w32.XOptions = ((global::Gtk.AttachOptions)(4));
		w32.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox3.Add (this.table1);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table1]));
		w33.Position = 0;
		w33.Expand = false;
		w33.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.dungeonMinimap = new global::LynnaLab.Minimap ();
		this.dungeonMinimap.WidthRequest = 240;
		this.dungeonMinimap.HeightRequest = 176;
		this.dungeonMinimap.Name = "dungeonMinimap";
		this.dungeonMinimap.Floor = 0;
		this.dungeonMinimap.SelectedIndex = 0;
		this.dungeonMinimap.Height = 8;
		this.dungeonMinimap.Width = 8;
		this.dungeonMinimap.TileWidth = 30;
		this.dungeonMinimap.TileHeight = 22;
		this.dungeonMinimap.Scale = 1;
		this.vbox3.Add (this.dungeonMinimap);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.dungeonMinimap]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		this.notebook2.Add (this.vbox3);
		global::Gtk.Notebook.NotebookChild w35 = ((global::Gtk.Notebook.NotebookChild)(this.notebook2 [this.vbox3]));
		w35.Position = 1;
		// Notebook tab
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Dungeons");
		this.notebook2.SetTabLabel (this.vbox3, this.label6);
		this.label6.ShowAll ();
		this.hbox3.Add (this.notebook2);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.notebook2]));
		w36.Position = 1;
		w36.Expand = false;
		w36.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.alignment2 = new global::Gtk.Alignment (0.5F, 0F, 1F, 0.53F);
		this.alignment2.Name = "alignment2";
		this.hbox3.Add (this.alignment2);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.alignment2]));
		w37.Position = 2;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w38.Position = 1;
		w38.Expand = false;
		w38.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 941;
		this.DefaultHeight = 520;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.OpenAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.QuitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.SaveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.AnimationsAction.Activated += new global::System.EventHandler (this.OnAnimationsActionActivated);
		this.roomSpinButton.ValueChanged += new global::System.EventHandler (this.OnRoomSpinButtonValueChanged);
		this.musicComboBox.Changed += new global::System.EventHandler (this.OnMusicComboBoxChanged);
		this.areaSpinButton.ValueChanged += new global::System.EventHandler (this.OnAreaSpinButtonValueChanged);
		this.areaEditorButton.Clicked += new global::System.EventHandler (this.OnAreaEditorButtonClicked);
		this.viewInteractionsCheckBox.Toggled += new global::System.EventHandler (this.OnViewInteractionsCheckBoxToggled);
		this.notebook2.SwitchPage += new global::Gtk.SwitchPageHandler (this.OnNotebook2SwitchPage);
		this.worldSpinButton.ValueChanged += new global::System.EventHandler (this.OnWorldSpinButtonValueChanged);
		this.floorSpinButton.ValueChanged += new global::System.EventHandler (this.OnFloorSpinButtonValueChanged);
		this.dungeonSpinButton.ValueChanged += new global::System.EventHandler (this.OnDungeonSpinButtonValueChanged);
	}
}

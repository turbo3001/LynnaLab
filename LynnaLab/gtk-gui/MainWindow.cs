
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action OpenAction;
	
	private global::Gtk.Action QuitAction;
	
	private global::Gtk.Action SaveAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.VBox vbox2;
	
	private global::LynnaLab.AreaViewer areaviewer1;
	
	private global::LynnaLab.RoomEditor roomeditor1;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Table table1;
	
	private global::Gtk.SpinButton dungeonSpinButton;
	
	private global::Gtk.SpinButton floorSpinButton;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.Label label2;
	
	private global::LynnaLab.Minimap minimap;

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
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction' action='SaveAction'/><menuitem name='QuitAction' action='QuitAction'/></menu></menubar></ui>");
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
		this.vbox2.Add (this.areaviewer1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.areaviewer1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.roomeditor1 = new global::LynnaLab.RoomEditor ();
		this.roomeditor1.WidthRequest = 240;
		this.roomeditor1.HeightRequest = 224;
		this.roomeditor1.Name = "roomeditor1";
		this.roomeditor1.Height = 14;
		this.roomeditor1.Width = 15;
		this.roomeditor1.TileWidth = 16;
		this.roomeditor1.TileHeight = 16;
		this.vbox2.Add (this.roomeditor1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.roomeditor1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.hbox3.Add (this.vbox2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
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
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.dungeonSpinButton]));
		w6.LeftAttach = ((uint)(1));
		w6.RightAttach = ((uint)(2));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.floorSpinButton = new global::Gtk.SpinButton (0, 100, 1);
		this.floorSpinButton.CanFocus = true;
		this.floorSpinButton.Name = "floorSpinButton";
		this.floorSpinButton.Adjustment.PageIncrement = 10;
		this.floorSpinButton.ClimbRate = 1;
		this.floorSpinButton.Numeric = true;
		this.table1.Add (this.floorSpinButton);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.floorSpinButton]));
		w7.TopAttach = ((uint)(1));
		w7.BottomAttach = ((uint)(2));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 1F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Dungeon Index");
		this.table1.Add (this.label1);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 1F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Floor");
		this.table1.Add (this.label2);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		this.vbox3.Add (this.table1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table1]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.minimap = new global::LynnaLab.Minimap ();
		this.minimap.WidthRequest = 240;
		this.minimap.HeightRequest = 176;
		this.minimap.Name = "minimap";
		this.minimap.Floor = 0;
		this.minimap.SelectedIndex = 0;
		this.minimap.Height = 8;
		this.minimap.Width = 8;
		this.minimap.TileWidth = 30;
		this.minimap.TileHeight = 22;
		this.vbox3.Add (this.minimap);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.minimap]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.hbox3.Add (this.vbox3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox3]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 526;
		this.DefaultHeight = 546;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.OpenAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
		this.QuitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.SaveAction.Activated += new global::System.EventHandler (this.OnSaveActionActivated);
		this.floorSpinButton.ValueChanged += new global::System.EventHandler (this.OnFloorSpinButtonValueChanged);
		this.dungeonSpinButton.ValueChanged += new global::System.EventHandler (this.OnDungeonSpinButtonValueChanged);
	}
}

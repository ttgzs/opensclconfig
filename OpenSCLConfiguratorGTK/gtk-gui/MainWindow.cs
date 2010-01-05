// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action FileAction;
    
    private Gtk.Action newAction;
    
    private Gtk.Action openAction;
    
    private Gtk.Action quitAction;
    
    private Gtk.Action saveAction;
    
    private Gtk.Action saveAsAction;
    
    private Gtk.Action AboutAction;
    
    private Gtk.Action aboutAction;
    
    private Gtk.VBox vbox1;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.Notebook notebook1;
    
    private LibOpenSCLUIGtk.SclEditor scleditor;
    
    private Gtk.Label TreeView;
    
    private Gtk.Label ConsoleView;
    
    private Gtk.Statusbar statusbar1;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("_File"), null, null);
        this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("_File");
        w1.Add(this.FileAction, null);
        this.newAction = new Gtk.Action("newAction", Mono.Unix.Catalog.GetString("_Nuevo"), null, "gtk-new");
        this.newAction.ShortLabel = Mono.Unix.Catalog.GetString("_Nuevo");
        w1.Add(this.newAction, null);
        this.openAction = new Gtk.Action("openAction", Mono.Unix.Catalog.GetString("_Abrir"), null, "gtk-open");
        this.openAction.ShortLabel = Mono.Unix.Catalog.GetString("_Abrir");
        w1.Add(this.openAction, null);
        this.quitAction = new Gtk.Action("quitAction", Mono.Unix.Catalog.GetString("_Salir"), null, "gtk-quit");
        this.quitAction.ShortLabel = Mono.Unix.Catalog.GetString("_Salir");
        w1.Add(this.quitAction, null);
        this.saveAction = new Gtk.Action("saveAction", Mono.Unix.Catalog.GetString("_Guardar"), null, "gtk-save");
        this.saveAction.ShortLabel = Mono.Unix.Catalog.GetString("_Guardar");
        w1.Add(this.saveAction, null);
        this.saveAsAction = new Gtk.Action("saveAsAction", Mono.Unix.Catalog.GetString("Guardar _como"), null, "gtk-save-as");
        this.saveAsAction.ShortLabel = Mono.Unix.Catalog.GetString("Guardar _como");
        w1.Add(this.saveAsAction, null);
        this.AboutAction = new Gtk.Action("AboutAction", Mono.Unix.Catalog.GetString("_About"), null, null);
        this.AboutAction.ShortLabel = Mono.Unix.Catalog.GetString("_About");
        w1.Add(this.AboutAction, null);
        this.aboutAction = new Gtk.Action("aboutAction", Mono.Unix.Catalog.GetString("Acerca _de"), null, "gtk-about");
        this.aboutAction.ShortLabel = Mono.Unix.Catalog.GetString("Acerca _de");
        w1.Add(this.aboutAction, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("OpenSCLConfigurator");
        this.Icon = Gdk.Pixbuf.LoadFromResource("OpenSCLConfiguratorGTK.LogoIEDConfigurator.png");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.vbox1 = new Gtk.VBox();
        this.vbox1.Name = "vbox1";
        this.vbox1.Spacing = 6;
        // Container child vbox1.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='newAction' action='newAction'/><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='saveAsAction' action='saveAsAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='AboutAction' action='AboutAction'><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.vbox1.Add(this.menubar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child vbox1.Gtk.Box+BoxChild
        this.notebook1 = new Gtk.Notebook();
        this.notebook1.CanFocus = true;
        this.notebook1.Name = "notebook1";
        this.notebook1.CurrentPage = 0;
        // Container child notebook1.Gtk.Notebook+NotebookChild
        this.scleditor = new LibOpenSCLUIGtk.SclEditor();
        this.scleditor.Events = ((Gdk.EventMask)(256));
        this.scleditor.Name = "scleditor";
        this.notebook1.Add(this.scleditor);
        // Notebook tab
        this.TreeView = new Gtk.Label();
        this.TreeView.Name = "TreeView";
        this.TreeView.LabelProp = Mono.Unix.Catalog.GetString("Tree View");
        this.notebook1.SetTabLabel(this.scleditor, this.TreeView);
        this.TreeView.ShowAll();
        // Notebook tab
        Gtk.Label w4 = new Gtk.Label();
        w4.Visible = true;
        this.notebook1.Add(w4);
        this.ConsoleView = new Gtk.Label();
        this.ConsoleView.Name = "ConsoleView";
        this.ConsoleView.LabelProp = Mono.Unix.Catalog.GetString("ConsoleView");
        this.notebook1.SetTabLabel(w4, this.ConsoleView);
        this.ConsoleView.ShowAll();
        this.vbox1.Add(this.notebook1);
        Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.notebook1]));
        w5.Position = 1;
        // Container child vbox1.Gtk.Box+BoxChild
        this.statusbar1 = new Gtk.Statusbar();
        this.statusbar1.Name = "statusbar1";
        this.statusbar1.Spacing = 6;
        this.vbox1.Add(this.statusbar1);
        Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
        w6.Position = 2;
        w6.Expand = false;
        w6.Fill = false;
        this.Add(this.vbox1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 668;
        this.DefaultHeight = 543;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.newAction.Activated += new System.EventHandler(this.OnNewEvent);
        this.openAction.Activated += new System.EventHandler(this.OnOpenEvent);
        this.quitAction.Activated += new System.EventHandler(this.OnExitEvent);
        this.saveAction.Activated += new System.EventHandler(this.OnSave);
        this.saveAsAction.Activated += new System.EventHandler(this.OnSaveAs);
        this.aboutAction.Activated += new System.EventHandler(this.OnAbout);
    }
}

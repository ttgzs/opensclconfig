// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LibOpenSCLUIGtk {
    
    
    public partial class SclEditor {
        
        private Gtk.HPaned hpaned4;
        
        private Gtk.ScrolledWindow treeview_scrolledwindow;
        
        private OpenSCLUIGtk.SclTree scltree;
        
        private Gtk.Notebook notebook;
        
        private Gtk.Label label6;
        
        private LibOpenSCLUIGtk.DeviceEditor deviceeditor;
        
        private Gtk.Label label5;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LibOpenSCLUIGtk.SclEditor
            Stetic.BinContainer.Attach(this);
            this.Name = "LibOpenSCLUIGtk.SclEditor";
            // Container child LibOpenSCLUIGtk.SclEditor.Gtk.Container+ContainerChild
            this.hpaned4 = new Gtk.HPaned();
            this.hpaned4.CanFocus = true;
            this.hpaned4.Name = "hpaned4";
            this.hpaned4.Position = 154;
            // Container child hpaned4.Gtk.Paned+PanedChild
            this.treeview_scrolledwindow = new Gtk.ScrolledWindow();
            this.treeview_scrolledwindow.CanFocus = true;
            this.treeview_scrolledwindow.Name = "treeview_scrolledwindow";
            this.treeview_scrolledwindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child treeview_scrolledwindow.Gtk.Container+ContainerChild
            this.scltree = new OpenSCLUIGtk.SclTree();
            this.scltree.CanFocus = true;
            this.scltree.Name = "scltree";
            this.treeview_scrolledwindow.Add(this.scltree);
            this.hpaned4.Add(this.treeview_scrolledwindow);
            Gtk.Paned.PanedChild w2 = ((Gtk.Paned.PanedChild)(this.hpaned4[this.treeview_scrolledwindow]));
            w2.Resize = false;
            // Container child hpaned4.Gtk.Paned+PanedChild
            this.notebook = new Gtk.Notebook();
            this.notebook.CanFocus = true;
            this.notebook.Name = "notebook";
            this.notebook.CurrentPage = 1;
            // Notebook tab
            Gtk.Label w3 = new Gtk.Label();
            w3.Visible = true;
            this.notebook.Add(w3);
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Nothing");
            this.notebook.SetTabLabel(w3, this.label6);
            this.label6.ShowAll();
            // Container child notebook.Gtk.Notebook+NotebookChild
            this.deviceeditor = new LibOpenSCLUIGtk.DeviceEditor();
            this.deviceeditor.Events = ((Gdk.EventMask)(256));
            this.deviceeditor.Name = "deviceeditor";
            this.notebook.Add(this.deviceeditor);
            Gtk.Notebook.NotebookChild w4 = ((Gtk.Notebook.NotebookChild)(this.notebook[this.deviceeditor]));
            w4.Position = 1;
            // Notebook tab
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("IED Editor");
            this.notebook.SetTabLabel(this.deviceeditor, this.label5);
            this.label5.ShowAll();
            this.hpaned4.Add(this.notebook);
            this.Add(this.hpaned4);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}

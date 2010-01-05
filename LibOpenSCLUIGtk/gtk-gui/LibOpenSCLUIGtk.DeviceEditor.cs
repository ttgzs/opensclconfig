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
    
    
    public partial class DeviceEditor {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action addAction;
        
        private Gtk.Action addAction1;
        
        private Gtk.Action propertiesAction;
        
        private Gtk.Action removeAction;
        
        private Gtk.Action propertiesAction1;
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Image image1;
        
        private Gtk.Label DeviceInformationLabel;
        
        private Gtk.Notebook notebook3;
        
        private Gtk.HPaned hpaned;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView treeview;
        
        private Gtk.Table table1;
        
        private Gtk.Entry iedconfigrevision;
        
        private Gtk.ComboBoxEntry iedmanufacturer;
        
        private Gtk.Entry iedname;
        
        private Gtk.Label label10;
        
        private Gtk.Label label8;
        
        private Gtk.Label label9;
        
        private Gtk.Label label7;
        
        private Gtk.Label label19;
        
        private Gtk.VBox vbox4;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label label13;
        
        private Gtk.ComboBox ldlist;
        
        private LibOpenSCLUIGtk.LDEdit ldedit;
        
        private Gtk.Label label12;
        
        private Gtk.Label label14;
        
        private Gtk.Label label17;
        
        private Gtk.Label DeviceDescription;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LibOpenSCLUIGtk.DeviceEditor
            Stetic.BinContainer w1 = Stetic.BinContainer.Attach(this);
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
            this.addAction = new Gtk.Action("addAction", null, null, "gtk-add");
            w2.Add(this.addAction, null);
            this.addAction1 = new Gtk.Action("addAction1", null, null, "gtk-add");
            w2.Add(this.addAction1, null);
            this.propertiesAction = new Gtk.Action("propertiesAction", null, null, "gtk-properties");
            w2.Add(this.propertiesAction, null);
            this.removeAction = new Gtk.Action("removeAction", null, null, "gtk-remove");
            w2.Add(this.removeAction, null);
            this.propertiesAction1 = new Gtk.Action("propertiesAction1", null, null, "gtk-properties");
            w2.Add(this.propertiesAction1, null);
            this.UIManager.InsertActionGroup(w2, 0);
            this.Name = "LibOpenSCLUIGtk.DeviceEditor";
            // Container child LibOpenSCLUIGtk.DeviceEditor.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            this.vbox3.BorderWidth = ((uint)(9));
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.image1 = new Gtk.Image();
            this.image1.Name = "image1";
            this.hbox1.Add(this.image1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.image1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.DeviceInformationLabel = new Gtk.Label();
            this.DeviceInformationLabel.Name = "DeviceInformationLabel";
            this.DeviceInformationLabel.LabelProp = Mono.Unix.Catalog.GetString("IED Information.\nManufacturer.\nConfiguration Revision.");
            this.DeviceInformationLabel.UseMarkup = true;
            this.DeviceInformationLabel.Selectable = true;
            this.hbox1.Add(this.DeviceInformationLabel);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.DeviceInformationLabel]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            this.vbox3.Add(this.hbox1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.notebook3 = new Gtk.Notebook();
            this.notebook3.CanFocus = true;
            this.notebook3.Name = "notebook3";
            this.notebook3.CurrentPage = 2;
            // Container child notebook3.Gtk.Notebook+NotebookChild
            this.hpaned = new Gtk.HPaned();
            this.hpaned.CanFocus = true;
            this.hpaned.Name = "hpaned";
            this.hpaned.Position = 125;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.treeview = new Gtk.TreeView();
            this.treeview.CanFocus = true;
            this.treeview.Name = "treeview";
            this.GtkScrolledWindow.Add(this.treeview);
            this.hpaned.Add(this.GtkScrolledWindow);
            Gtk.Paned.PanedChild w7 = ((Gtk.Paned.PanedChild)(this.hpaned[this.GtkScrolledWindow]));
            w7.Resize = false;
            // Container child hpaned.Gtk.Paned+PanedChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.iedconfigrevision = new Gtk.Entry();
            this.iedconfigrevision.CanFocus = true;
            this.iedconfigrevision.Name = "iedconfigrevision";
            this.iedconfigrevision.IsEditable = true;
            this.iedconfigrevision.InvisibleChar = '●';
            this.table1.Add(this.iedconfigrevision);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.iedconfigrevision]));
            w8.TopAttach = ((uint)(2));
            w8.BottomAttach = ((uint)(3));
            w8.LeftAttach = ((uint)(1));
            w8.RightAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.iedmanufacturer = Gtk.ComboBoxEntry.NewText();
            this.iedmanufacturer.AppendText(Mono.Unix.Catalog.GetString("ABB"));
            this.iedmanufacturer.AppendText(Mono.Unix.Catalog.GetString("AREVA"));
            this.iedmanufacturer.AppendText(Mono.Unix.Catalog.GetString("GENERAL ELECTRIC"));
            this.iedmanufacturer.AppendText(Mono.Unix.Catalog.GetString("INGETEAM"));
            this.iedmanufacturer.AppendText(Mono.Unix.Catalog.GetString("SEL"));
            this.iedmanufacturer.AppendText(Mono.Unix.Catalog.GetString("SIEMENS"));
            this.iedmanufacturer.AppendText("");
            this.iedmanufacturer.TooltipMarkup = "Select the manufacturer";
            this.iedmanufacturer.Name = "iedmanufacturer";
            this.table1.Add(this.iedmanufacturer);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.iedmanufacturer]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.LeftAttach = ((uint)(1));
            w9.RightAttach = ((uint)(2));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.iedname = new Gtk.Entry();
            this.iedname.TooltipMarkup = "IED's name";
            this.iedname.CanFocus = true;
            this.iedname.Name = "iedname";
            this.iedname.IsEditable = true;
            this.iedname.InvisibleChar = '●';
            this.table1.Add(this.iedname);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.iedname]));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label10 = new Gtk.Label();
            this.label10.Name = "label10";
            this.label10.LabelProp = Mono.Unix.Catalog.GetString("Conf. Rev.:");
            this.table1.Add(this.label10);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.label10]));
            w11.TopAttach = ((uint)(2));
            w11.BottomAttach = ((uint)(3));
            w11.XOptions = ((Gtk.AttachOptions)(4));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("IED Name:");
            this.table1.Add(this.label8);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table1[this.label8]));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("Manufacturer:");
            this.table1.Add(this.label9);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table1[this.label9]));
            w13.TopAttach = ((uint)(1));
            w13.BottomAttach = ((uint)(2));
            w13.XOptions = ((Gtk.AttachOptions)(4));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            this.hpaned.Add(this.table1);
            this.notebook3.Add(this.hpaned);
            // Notebook tab
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("IED");
            this.notebook3.SetTabLabel(this.hpaned, this.label7);
            this.label7.ShowAll();
            // Notebook tab
            Gtk.Label w16 = new Gtk.Label();
            w16.Visible = true;
            this.notebook3.Add(w16);
            this.label19 = new Gtk.Label();
            this.label19.Name = "label19";
            this.label19.LabelProp = Mono.Unix.Catalog.GetString("Communications");
            this.notebook3.SetTabLabel(w16, this.label19);
            this.label19.ShowAll();
            // Container child notebook3.Gtk.Notebook+NotebookChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            this.vbox4.BorderWidth = ((uint)(3));
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.label13 = new Gtk.Label();
            this.label13.Name = "label13";
            this.label13.LabelProp = Mono.Unix.Catalog.GetString("Logical Device");
            this.hbox3.Add(this.label13);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox3[this.label13]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.ldlist = Gtk.ComboBox.NewText();
            this.ldlist.TooltipMarkup = "Select an existing LD In the IED";
            this.ldlist.Name = "ldlist";
            this.hbox3.Add(this.ldlist);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox3[this.ldlist]));
            w18.Position = 1;
            w18.Expand = false;
            w18.Fill = false;
            this.vbox4.Add(this.hbox3);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
            w19.Position = 0;
            w19.Expand = false;
            w19.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.ldedit = new LibOpenSCLUIGtk.LDEdit();
            this.ldedit.Events = ((Gdk.EventMask)(256));
            this.ldedit.Name = "ldedit";
            this.vbox4.Add(this.ldedit);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox4[this.ldedit]));
            w20.Position = 1;
            this.notebook3.Add(this.vbox4);
            Gtk.Notebook.NotebookChild w21 = ((Gtk.Notebook.NotebookChild)(this.notebook3[this.vbox4]));
            w21.Position = 2;
            // Notebook tab
            this.label12 = new Gtk.Label();
            this.label12.Name = "label12";
            this.label12.LabelProp = Mono.Unix.Catalog.GetString("Logical Device");
            this.notebook3.SetTabLabel(this.vbox4, this.label12);
            this.label12.ShowAll();
            // Notebook tab
            Gtk.Label w22 = new Gtk.Label();
            w22.Visible = true;
            this.notebook3.Add(w22);
            this.label14 = new Gtk.Label();
            this.label14.Name = "label14";
            this.label14.LabelProp = Mono.Unix.Catalog.GetString("Data Type Templates");
            this.notebook3.SetTabLabel(w22, this.label14);
            this.label14.ShowAll();
            // Notebook tab
            Gtk.Label w23 = new Gtk.Label();
            w23.Visible = true;
            this.notebook3.Add(w23);
            this.label17 = new Gtk.Label();
            this.label17.TooltipMarkup = "View and Edit Private nodes on current IED";
            this.label17.Name = "label17";
            this.label17.LabelProp = Mono.Unix.Catalog.GetString("Private");
            this.notebook3.SetTabLabel(w23, this.label17);
            this.label17.ShowAll();
            this.vbox3.Add(this.notebook3);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox3[this.notebook3]));
            w24.Position = 1;
            // Container child vbox3.Gtk.Box+BoxChild
            this.DeviceDescription = new Gtk.Label();
            this.DeviceDescription.Name = "DeviceDescription";
            this.DeviceDescription.Xalign = 0F;
            this.DeviceDescription.LabelProp = Mono.Unix.Catalog.GetString("IED Description");
            this.DeviceDescription.UseMarkup = true;
            this.DeviceDescription.Selectable = true;
            this.vbox3.Add(this.DeviceDescription);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox3[this.DeviceDescription]));
            w25.PackType = ((Gtk.PackType)(1));
            w25.Position = 2;
            w25.Expand = false;
            w25.Fill = false;
            this.Add(this.vbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            w1.SetUiManager(UIManager);
            this.Hide();
        }
    }
}
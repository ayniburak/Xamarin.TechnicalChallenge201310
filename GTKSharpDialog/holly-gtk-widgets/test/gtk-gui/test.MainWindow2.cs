// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    
    
    public partial class MainWindow2 {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Button button4;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button button3;
        
        private HollyLibrary.HImageCheckBox himagecheckbox1;
        
        private Gtk.Button button2;
        
        private Gtk.Button button5;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget test.MainWindow2
            this.Name = "test.MainWindow2";
            this.Title = Mono.Unix.Catalog.GetString("MainWindow2");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Container child test.MainWindow2.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.button4 = new Gtk.Button();
            this.button4.CanFocus = true;
            this.button4.Name = "button4";
            this.button4.UseUnderline = true;
            this.button4.Label = Mono.Unix.Catalog.GetString("button4");
            this.vbox1.Add(this.button4);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox1[this.button4]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.button3 = new Gtk.Button();
            this.button3.CanFocus = true;
            this.button3.Name = "button3";
            this.button3.UseUnderline = true;
            this.button3.Label = Mono.Unix.Catalog.GetString("button3");
            this.hbox1.Add(this.button3);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.button3]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.himagecheckbox1 = new HollyLibrary.HImageCheckBox();
            this.himagecheckbox1.Events = ((Gdk.EventMask)(256));
            this.himagecheckbox1.Name = "himagecheckbox1";
            this.himagecheckbox1.Checked = false;
            this.himagecheckbox1.Text = "gigi duru";
            this.hbox1.Add(this.himagecheckbox1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.himagecheckbox1]));
            w3.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            this.button2 = new Gtk.Button();
            this.button2.CanFocus = true;
            this.button2.Name = "button2";
            this.button2.UseUnderline = true;
            this.button2.Label = Mono.Unix.Catalog.GetString("button2");
            this.hbox1.Add(this.button2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.button2]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            this.vbox1.Add(this.hbox1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w5.Position = 1;
            // Container child vbox1.Gtk.Box+BoxChild
            this.button5 = new Gtk.Button();
            this.button5.CanFocus = true;
            this.button5.Name = "button5";
            this.button5.UseUnderline = true;
            this.button5.Label = Mono.Unix.Catalog.GetString("button5");
            this.vbox1.Add(this.button5);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.button5]));
            w6.Position = 2;
            w6.Expand = false;
            w6.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        }
    }
}

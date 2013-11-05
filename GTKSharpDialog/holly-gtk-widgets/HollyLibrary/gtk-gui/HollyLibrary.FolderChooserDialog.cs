
// This file has been generated by the GUI designer. Do not modify.
namespace HollyLibrary
{
	public partial class FolderChooserDialog
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::HollyLibrary.HTreeView FolderTree;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label1;
		private global::Gtk.Entry TxtNewFolder;
		private global::Gtk.Button BtnNewFolder;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HollyLibrary.FolderChooserDialog
			this.Name = "HollyLibrary.FolderChooserDialog";
			this.Title = "FolderChooserDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(2));
			this.Decorated = false;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			this.FocusOnMap = false;
			// Container child HollyLibrary.FolderChooserDialog.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(4));
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow.BorderWidth = ((uint)(2));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.FolderTree = null;
			this.GtkScrolledWindow.Add (this.FolderTree);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = "Add new folder:";
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.TxtNewFolder = new global::Gtk.Entry ();
			this.TxtNewFolder.CanFocus = true;
			this.TxtNewFolder.Name = "TxtNewFolder";
			this.TxtNewFolder.IsEditable = true;
			this.TxtNewFolder.InvisibleChar = '●';
			this.hbox1.Add (this.TxtNewFolder);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.TxtNewFolder]));
			w5.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.BtnNewFolder = new global::Gtk.Button ();
			this.BtnNewFolder.CanFocus = true;
			this.BtnNewFolder.Name = "BtnNewFolder";
			this.BtnNewFolder.UseStock = true;
			this.BtnNewFolder.UseUnderline = true;
			this.BtnNewFolder.Label = "gtk-add";
			this.hbox1.Add (this.BtnNewFolder);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.BtnNewFolder]));
			w6.Position = 2;
			w6.Expand = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 355;
			this.DefaultHeight = 271;
			this.Hide ();
			this.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnButtonPressEvent);
			this.TxtNewFolder.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnTxtNewFolderKeyReleaseEvent);
			this.BtnNewFolder.Clicked += new global::System.EventHandler (this.OnBtnNewFolderClicked);
			this.BtnNewFolder.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnNewFolderButtonPressEvent);
		}
	}
}

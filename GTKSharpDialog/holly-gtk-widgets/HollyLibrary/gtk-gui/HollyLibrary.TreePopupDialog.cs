
// This file has been generated by the GUI designer. Do not modify.
namespace HollyLibrary
{
	public partial class TreePopupDialog
	{
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::HollyLibrary.HTreeView Tree;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HollyLibrary.TreePopupDialog
			this.Name = "HollyLibrary.TreePopupDialog";
			this.Title = "TreePopupDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Decorated = false;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Container child HollyLibrary.TreePopupDialog.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.Tree = null;
			this.GtkScrolledWindow.Add (this.Tree);
			this.Add (this.GtkScrolledWindow);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 322;
			this.DefaultHeight = 325;
			this.Hide ();
			this.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnButtonPressEvent);
		}
	}
}

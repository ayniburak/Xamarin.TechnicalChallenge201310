;
tv.HeadersVisible = true;
v.Add (tv);

TreeViewColumn col = new TreeViewColumn ( );
CellRenderer colr = new CellRendererText ( );
col.Title = "Column 1";
col.PackStart (colr, true);
col.AddAttribute (colr, "text", 0);
tv.AppendColumn (col);

col = new TreeViewColumn ( );
colr = new CellRendererText ( );
col.Title = "Column 2";
col.PackStart (colr, true);
col.AddAttribute (colr, "text", 1);
tv.AppendColumn (col);

ListStore store = new ListStore (typeof (string), typeof (string));
tv.Model = store;

TreeIter iter = new TreeIter ( );
for (int i = 0; i < 4; i++) {
	iter = store.AppendValues ("Point " + i.ToString ( ),
	                           "Distance " + (4-i).ToString ( ));
	 
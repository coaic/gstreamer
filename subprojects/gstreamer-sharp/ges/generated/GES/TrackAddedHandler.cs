// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void TrackAddedHandler(object o, TrackAddedArgs args);

	public class TrackAddedArgs : GLib.SignalArgs {
		public GES.Track Track{
			get {
				return (GES.Track) Args [0];
			}
		}

	}
}
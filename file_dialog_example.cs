using Godot;
using System;

public partial class file_dialog_example : Control
{
	private FileDialog file_dialog;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		file_dialog = GetNode<FileDialog>("FileDialogExample");
		file_dialog.Visible = true;
		file_dialog.PopupCentered();
	}
}


